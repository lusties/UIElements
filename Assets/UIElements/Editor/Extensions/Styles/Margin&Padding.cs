using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Margin---------------

        public static T Margin<T>(this T element,
            float? left, float? top, float? right, float? bottom, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(left, top, right, bottom, unit);
            return element;
        }

        public static T Margin<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(value, value, value, value, unit);
            return element;
        }
        
        public static T MarginLeft<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(value, null, null, null, unit);
            return element;
        }
        
        public static T MarginTop<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(null, value, null, null, unit);
            return element;
        }
        
        public static T MarginRight<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(null, null, value, null, unit);
            return element;
        }
        
        public static T MarginBottom<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Margin(null, null, null, value, unit);
            return element;
        }

        public static IStyle Margin(this IStyle style,
            float? left = null, float? top = null, float? right = null, float? bottom = null, LengthUnit unit = LengthUnit.Percent)
        {
            if (left != null)
                style.marginLeft = new Length(left.Value, unit);
            if (top != null)
                style.marginTop = new Length(top.Value, unit);
            if (right != null)
                style.marginRight = new Length(right.Value, unit);
            if (bottom != null)
                style.marginBottom = new Length(bottom.Value, unit);

            return style;
        }

        #endregion


        #region ---------------Padding---------------

        public static T Padding<T>(this T element,
            float? left, float? top, float? right, float? bottom, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(left, right, top, bottom, unit);
            return element;
        }
        
        public static T Padding<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(value, value, value, value, unit);
            return element;
        }
        
        public static T PaddingLeft<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(value, null, null, null, unit);
            return element;
        }
        
        public static T PaddingTop<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(null, value, null, null, unit);
            return element;
        }
        
        public static T PaddingRight<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(null, null, value, null, unit);
            return element;
        }
        
        public static T PaddingBottom<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.Padding(null, null, null, value, unit);
            return element;
        }

        public static IStyle Padding(this IStyle style,
            float? left = null, float? top = null, float? right = null, float? bottom = null, LengthUnit unit = LengthUnit.Percent)
        {
            if (left != null)
                style.paddingLeft = new Length(left.Value, unit);
            if (top != null)
                style.paddingTop = new Length(top.Value, unit);
            if (right != null)
                style.paddingRight = new Length(right.Value, unit);
            if (bottom != null)
                style.paddingBottom = new Length(bottom.Value, unit);

            return style;
        }
        #endregion
    }
}