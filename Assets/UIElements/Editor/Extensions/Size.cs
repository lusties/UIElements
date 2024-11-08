using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        public static T SetSize<T>(this T element, float width = -1f, float height = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.SetSize(width, height, unit);
            return element;
        }
        
        public static T SetWidth<T>(this T element, float width = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.SetSize(width, -1, unit);
            return element;
        }
        
        public static T SetHeight<T>(this T element, float height = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.SetSize(-1, height, unit);
            return element;
        }

        public static IStyle SetSize(this IStyle style, float width = -1f, float height = -1f, LengthUnit unit = LengthUnit.Pixel)
        {
            if (width != -1f)
                style.width = new Length(width, unit);
            if (height != -1f)
                style.height = new Length(height, unit);

            return style;
        }
    }
}