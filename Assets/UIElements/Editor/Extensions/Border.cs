using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Set Border Width---------------

        public static T SetBordersWidth<T>(this T element, float width)
            where T : VisualElement
        {
            element.style.SetBordersWidth(width);
            return element;
        }

        public static IStyle SetBordersWidth(this IStyle style, float width) 
        {
            style.borderTopWidth = style.borderBottomWidth = style.borderLeftWidth = style.borderRightWidth
                 = new StyleFloat(width);
            return style;
        }
        
        public static T SetBorderWidth<T>(this T element,
            float borderTopWidth, float borderBottomWidth = -1f, float borderLeftWidth = -1f, float borderRightWidth = -1f)
            where T : VisualElement
        {
            element.style.SetBorderWidth(borderTopWidth, borderBottomWidth, borderLeftWidth, borderRightWidth);
            return element;
        }
        
        public static IStyle SetBorderWidth(this IStyle style, 
            float borderTopWidth, float borderBottomWidth = -1f, float borderLeftWidth = -1f, float borderRightWidth = -1f)
        {
            if(borderTopWidth < 0f)
                style.borderTopWidth = borderTopWidth;
            if(borderBottomWidth < 0f)
                style.borderBottomWidth = borderBottomWidth;
            if(borderLeftWidth < 0f)
                style.borderLeftWidth = borderLeftWidth;
            if(borderRightWidth < 0f)
                style.borderRightWidth = borderRightWidth;
            return style;
        }

        #endregion
        
        #region ---------------Set Border Radius---------------

        public static T SetBorderRadius<T>(this T element,
            float topRight = -1f, float bottomRight = -1f, float bottomLeft = -1f, float topLeft = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement

        {
            element.style.SetBorderRadius(topRight, bottomRight, bottomLeft, topLeft, unit);
            return element;
        }

        public static IStyle SetBorderRadius(this IStyle style,
            float topRight = -1f, float bottomRight = -1f, float bottomLeft = -1f, float topLeft = -1f, LengthUnit unit = LengthUnit.Pixel)
        {
            if (topRight != -1f)
                style.borderTopRightRadius = new Length(topRight, unit);
            if (bottomRight != -1f)
                style.borderBottomRightRadius = new Length(bottomRight, unit);
            if (bottomLeft != -1f)
                style.borderBottomLeftRadius = new Length(bottomLeft, unit);
            if (topLeft != -1f)
                style.borderTopLeftRadius = new Length(topLeft, unit);

            return style;
        }

        public static T SetBordersRadius<T>(this T element, float radius, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.SetBordersRadius(radius, unit);
            return element;
        }

        public static IStyle SetBordersRadius(this IStyle style, float radius, LengthUnit unit = LengthUnit.Pixel)
        {
            style.borderTopRightRadius = style.borderTopLeftRadius = style.borderBottomRightRadius = style.borderBottomLeftRadius
                = new Length(radius, unit);
            return style;
        }

        #endregion


        #region ---------------Set Border Color---------------

        public static T SetBorderColor<T>(this T element, Color color)
            where T : VisualElement
        {
            element.style.SetBorderColor(color);
            return element;
        }

        public static IStyle SetBorderColor(this IStyle style, Color color) 
        {
            style.borderLeftColor = style.borderRightColor = style.borderTopColor = style.borderBottomColor = color;
            return style;
        }

        #endregion
    }
}