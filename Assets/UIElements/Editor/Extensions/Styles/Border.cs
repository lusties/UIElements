using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class StyleExtensions
    {
        #region ---------------Set Border Width---------------

        public static T BordersWidth<T>(this T element, float width)
            where T : VisualElement
        {
            element.style.BordersWidth(width);
            return element;
        }

        public static IStyle BordersWidth(this IStyle style, float width) 
        {
            style.borderTopWidth = style.borderBottomWidth = style.borderLeftWidth = style.borderRightWidth
                 = new StyleFloat(width);
            return style;
        }
        
        public static T BorderWidth<T>(this T element,
            float borderTopWidth, float borderBottomWidth = -1f, float borderLeftWidth = -1f, float borderRightWidth = -1f)
            where T : VisualElement
        {
            element.style.BorderWidth(borderTopWidth, borderBottomWidth, borderLeftWidth, borderRightWidth);
            return element;
        }
        
        public static IStyle BorderWidth(this IStyle style, 
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

        public static T BorderRadius<T>(this T element,
            float topRight, float bottomRight, float bottomLeft, float topLeft, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement

        {
            element.style.BorderRadius(topRight, bottomRight, bottomLeft, topLeft, unit);
            return element;
        }
        
        public static T BorderRadius<T>(this T element, float radius, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.BorderRadius(radius, radius, radius, radius, unit);
            return element;
        }

        public static IStyle BorderRadius(this IStyle style,
            float topRight = -1f, float bottomRight = -1f, float bottomLeft = -1f, float topLeft = -1f, LengthUnit unit = LengthUnit.Pixel)
        {
            if (topRight < 0)
                style.borderTopRightRadius = new Length(topRight, unit);
            if (bottomRight < 0)
                style.borderBottomRightRadius = new Length(bottomRight, unit);
            if (bottomLeft < 0)
                style.borderBottomLeftRadius = new Length(bottomLeft, unit);
            if (topLeft < 0)
                style.borderTopLeftRadius = new Length(topLeft, unit);

            return style;
        }

        #endregion

        #region ---------------Set Border Color---------------

        public static T BorderColor<T>(this T element, Color color)
            where T : VisualElement
        {
            element.style.BorderColor(color);
            return element;
        }

        public static IStyle BorderColor(this IStyle style, Color color) 
        {
            style.borderLeftColor = style.borderRightColor = style.borderTopColor = style.borderBottomColor = color;
            return style;
        }

        #endregion
    }
}