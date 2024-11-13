using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class StyleExtensions
    {
        public static T Size<T>(this T element, float? width, float? height, LengthUnit unit = LengthUnit.Pixel)
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

        #region ---------------Max-Min---------------
        public static T MaxSize<T>(this T element, float width, float height, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            return element.MaxWidth(width, unit).MaxHeight(height, unit);
        }
        
        public static T MinSize<T>(this T element, float width, float height, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            return element.MinWidth(width, unit).MinHeight(height, unit);
        }
        
        public static T MaxWidth<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.MaxWidth(value, unit);
            return element;
        }
        
        public static T MinWidth<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.MinWidth(value, unit);
            return element;
        }
        
        public static T MaxHeight<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.MaxHeight(value, unit);
            return element;
        }
        
        public static T MinHeight<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T: VisualElement
        {
            element.style.MinHeight(value, unit);
            return element;
        }

        public static IStyle MaxWidth(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.maxWidth = new Length(value, unit);
            return style;
        }
        
        public static IStyle MinWidth(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.minWidth = new Length(value, unit);
            return style;
        }
        
        public static IStyle MaxHeight(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.maxHeight = new Length(value, unit);
            return style;
        }
        
        public static IStyle MinHeight(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.minHeight = new Length(value, unit);
            return style;
        }

        #endregion
    }
}