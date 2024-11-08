using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Margin---------------

        public static T SetMargin<T>(this T element,
            float left = -1f, float right = -1f, float top = -1, float bottom = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.SetMargin(left, right, top, bottom, unit);
            return element;
        }

        public static IStyle SetMargin(this IStyle style,
            float left = -1f, float right = -1f, float top = -1f, float bottom = -1f, LengthUnit unit = LengthUnit.Percent)
        {
            if (left != -1f)
                style.marginLeft = new Length(left, unit);
            if (right != -1f)
                style.marginRight = new Length(right, unit);
            if (top != -1f)
                style.marginTop = new Length(top, unit);
            if (bottom != -1f)
                style.marginBottom = new Length(bottom, unit);

            return style;
        }

        #endregion


        #region ---------------Padding---------------

        public static T SetPadding<T>(this T element,
            float left = -1f, float right = -1f, float top = -1f, float bottom = -1f, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.SetPadding(left, right, top, bottom, unit);
            return element;
        }

        public static IStyle SetPadding(this IStyle style,
            float left = -1f, float right = -1f, float top = -1f, float bottom = -1f, LengthUnit unit = LengthUnit.Pixel)
        {
            if (left != -1f)
                style.paddingLeft = new Length(left, unit);
            if (right != -1f)
                style.paddingRight = new Length(right, unit);
            if (top != -1f)
                style.paddingTop = new Length(top, unit);
            if (bottom != -1f)
                style.paddingBottom = new Length(bottom, unit);

            return style;
        }
        #endregion
    }
}