using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        public static T Size<T>(this T element, float width, float height, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.Size(width, height, unit);
            return element;
        }
        
        public static T Width<T>(this T element, float width, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.Size(width, null, unit);
            return element;
        }
        
        public static T Height<T>(this T element, float height, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.Size(null, height, unit);
            return element;
        }

        public static IStyle Size(this IStyle style, float? width = null, float? height = null, LengthUnit unit = LengthUnit.Pixel)
        {
            if (width != null)
                style.width = new Length(width.Value, unit);
            if (height != null)
                style.height = new Length(height.Value, unit);

            return style;
        }
    }
}