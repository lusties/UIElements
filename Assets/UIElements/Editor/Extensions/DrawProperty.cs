using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static class DrawProperty
    {
        /// <inheritdoc cref="DrawProperties(UnityEditor.SerializedProperty, UnityEngine.UIElements.VisualElement,bool)"/>
        public static VisualElement DrawProperties(this SerializedProperty property, bool skipHeader = true)
        {
            VisualElement propertyContainer = new VisualElement();
    
            DrawProperties(property, propertyContainer, skipHeader);
    
            return propertyContainer;
        }

        /// <summary>
        /// Draws all the properties of a SerializedProperty into a container.
        /// </summary>
        /// <param name="property">Serialized Property</param>
        /// <param name="propertyContainer">The VisualElement containing the drawn properties</param>
        /// <param name="skipFirst">Skip the first property, useful for skip m_Script(MonoScript) field of Unity.Object</param>
        public static void DrawProperties(this SerializedProperty property, VisualElement propertyContainer, bool skipFirst = true)
        {
            SerializedProperty iterator = property.Copy();
            //SerializedProperty endProperty = iterator.GetEndProperty(); // End property marker (commented out)

            // Hide the
            if (iterator.NextVisible(skipFirst))
            {
                var propertyField = new PropertyField(iterator);
                propertyField.Bind(property.serializedObject);

                propertyContainer.Add(propertyField);
            }

            while (iterator.NextVisible(false) /*&& !SerializedProperty.EqualContents(iterator, endProperty)*/)
            {
                var propertyField = new PropertyField(iterator);
                propertyField.Bind(property.serializedObject);

                propertyContainer.Add(propertyField);
            }
        }

    }
}