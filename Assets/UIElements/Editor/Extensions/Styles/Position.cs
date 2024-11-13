using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class StyleExtensions
    {
        #region ---------------Position---------------

        public static T Position<T>(this T element, 
            float left, float top, float right, float bottom, LengthUnit unit = LengthUnit.Pixel) 
            where T : VisualElement
        {
            return element
                .Left(left, unit)
                .Top(top, unit)
                .Right(right, unit)
                .Bottom(bottom, unit);
        }

        public static T Position<T>(this T element, Position position) where T : VisualElement
        {
            element.style.Position(position);
            return element;
        }
        
        public static IStyle Position(this IStyle style, Position position)
        {
            style.position = position;
            return style;
        }
        #endregion
        
        #region ---------------Left---------------
        public static T Left<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel) where T : VisualElement
        {
            element.style.Left(value, unit);
            return element;
        }
        
        public static IStyle Left(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.left = new Length(value, unit);
            return style;
        }
        #endregion
        
        #region ---------------Top---------------
        public static T Top<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel) where T : VisualElement
        {
            element.style.Top(value, unit);
            return element;
        }
        
        public static IStyle Top(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.top = new Length(value, unit);
            return style;
        }
        #endregion
        
        #region ---------------Right---------------
        public static T Right<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel) where T : VisualElement
        {
            element.style.Right(value, unit);
            return element;
        }
        
        public static IStyle Right(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.right = new Length(value, unit);
            return style;
        }
        #endregion
        
        #region ---------------Bottom---------------
        public static T Bottom<T>(this T element, float value, LengthUnit unit = LengthUnit.Pixel) where T : VisualElement
        {
            element.style.Bottom(value, unit);
            return element;
        }
        
        public static IStyle Bottom(this IStyle style, float value, LengthUnit unit = LengthUnit.Pixel)
        {
            style.bottom = new Length(value, unit);
            return style;
        }
        #endregion
    }
}