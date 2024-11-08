using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        public static T SetDisplay<T>(this T element, bool display)
            where T : VisualElement
        {
            element.style.SetDisplay(display);
            return element;
        }

        public static IStyle SetDisplay(this IStyle style, bool display)
        {
            style.display = display? DisplayStyle.Flex : DisplayStyle.None;
            return style;
        }
        
        public static IStyle SetDisplay(this IStyle style, DisplayStyle display)
        {
            style.display = display;
            return style;
        }
    }
}