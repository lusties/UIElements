using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        public static T SetAlignSelf<T>(this T element, Align align) where T : VisualElement
        {
            element.style.SetAlignSelf(align);
            return element;
        }

        public static IStyle SetAlignSelf(this IStyle style, Align align)
        {
            style.alignSelf = align;
            return style;
        }
        
        public static T SetAlignContent<T>(this T element, Align align) where T : VisualElement
        {
            element.style.SetAlignContent(align);
            return element;
        }
        
        public static IStyle SetAlignContent(this IStyle style, Align align)
        {
            style.alignContent = align;
            return style;
        }
    }
}