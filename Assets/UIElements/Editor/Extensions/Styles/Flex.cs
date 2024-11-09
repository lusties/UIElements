using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Flex Grow---------------
        public static T FlexGrow<T>(this T element, float value)
            where T : VisualElement
        {
            element.style.FlexGrow(value);
            return element;
        }

        public static IStyle FlexGrow(this IStyle style, float value)
        {
            style.flexGrow = new StyleFloat(value);
            return style;
        }
        #endregion

        #region ---------------Flex Shrink---------------
        public static T FlexShrink<T>(this T element, float value)
            where T : VisualElement
        {
            element.style.FlexShrink(value);
            return element;
        }

        public static IStyle FlexShrink(this IStyle style, float value)
        {
            style.flexShrink = new StyleFloat(value);
            return style;
        }
        #endregion

        #region ---------------Flex Direction---------------
        public static T FlexDirection<T>(this T element, FlexDirection flexDirection)
            where T : VisualElement
        {
            element.style.FlexDirection(flexDirection);
            return element;
        }
        
        public static IStyle FlexDirection(this IStyle style, FlexDirection flexDirection)
        {
            style.flexDirection = flexDirection;
            return style;
        }
        #endregion
    }
}