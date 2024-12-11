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
        
        public static T Name<T>(this T element, string name)
            where T : VisualElement
        {
            element.name = name;
            return element;
        }
        
        public static VisualElement Child(this VisualElement element, int index)
        {
            return Child<VisualElement>(element, index);
        }

        public static TChild Child<TChild>(this VisualElement element, int index)
            where TChild : VisualElement
        {
            var children = element.Children();
            int i = 0;
            
            foreach (var child in children)
            {
                if (i == index)
                {
                    return child as TChild;
                }

                i++;
            }
            
            return null;
        }

        public static T1 Append<T1, T2>(this T1 element, T2 child)
            where T1 : VisualElement
            where T2 : VisualElement
        {
            element.Add(child);
            return element;
        }
    }
}