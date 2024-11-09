using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Display---------------
        public static T Display<T>(this T element, bool display)
            where T : VisualElement
        {
            element.style.Display(display);
            return element;
        }

        public static IStyle Display(this IStyle style, bool display)
        {
            style.display = display? DisplayStyle.Flex : DisplayStyle.None;
            return style;
        }
        
        public static IStyle Display(this IStyle style, DisplayStyle display)
        {
            style.display = display;
            return style;
        }
        #endregion

        #region ---------------Visibility---------------

        public static T Visibility<T>(this T element, bool visibility)
            where T : VisualElement
        {
            element.style.Visibility(visibility);
            return element;
        }

        public static IStyle Visibility(this IStyle style, bool visibility)
        {
            style.visibility = visibility? UnityEngine.UIElements.Visibility.Visible : UnityEngine.UIElements.Visibility.Hidden;
            return style;
        }
        
        public static IStyle Visibility(this IStyle style, Visibility visibility)
        {
            style.visibility = visibility;
            return style;
        }

        #endregion
    }
}