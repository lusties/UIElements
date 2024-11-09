using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        public static T AlignSelf<T>(this T element, Align align) where T : VisualElement
        {
            element.style.AlignSelf(align);
            return element;
        }

        public static IStyle AlignSelf(this IStyle style, Align align)
        {
            style.alignSelf = align;
            return style;
        }
        
        public static T AlignContent<T>(this T element, Align align) where T : VisualElement
        {
            element.style.AlignContent(align);
            return element;
        }
        
        public static IStyle AlignContent(this IStyle style, Align align)
        {
            style.alignContent = align;
            return style;
        }
        
        public static T JustifyContent<T>(this T element, Justify justify) where T : VisualElement
        {
            element.style.JustifyContent(justify);
            return element;
        }
        
        public static IStyle JustifyContent(this IStyle style, Justify justify)
        {
            style.justifyContent = justify;
            return style;
        }
    }
}