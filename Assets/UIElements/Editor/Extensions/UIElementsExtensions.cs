using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementsExtensions
    {
        #region ---------------Classes---------------
        public static T AddClasses<T>(this T element, params string[] classNames)
            where T : VisualElement
        {
            foreach (string className in classNames)
            {
                element.AddToClassList(className);
            }
            return element;
        }
        #endregion

        public static T1 Append<T1, T2>(this T1 element, T2 child)
            where T1 : VisualElement
            where T2 : VisualElement
        {
            element.Add(child);
            return element;
        }
    }
}
