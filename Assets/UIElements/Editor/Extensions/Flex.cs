using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Flex Grow---------------
        public static T SetFlexGrow<T>(this T element, float value)
            where T : VisualElement
        {
            element.style.SetFlexGrow(value);
            return element;
        }

        public static IStyle SetFlexGrow(this IStyle style, float value)
        {
            style.flexGrow = new StyleFloat(value);
            return style;
        }
        #endregion

        #region ---------------Flex Shrink---------------
        public static T SetFlexShrink<T>(this T element, float value)
            where T : VisualElement
        {
            element.style.SetFlexShrink(value);
            return element;
        }

        public static IStyle SetFlexShrink(this IStyle style, float value)
        {
            style.flexShrink = new StyleFloat(value);
            return style;
        }
        #endregion

        #region ---------------Flex Direction---------------
        public static T SetFlexDirection<T>(this T element, FlexDirection flexDirection)
            where T : VisualElement
        {
            element.style.SetFlexDirection(flexDirection);
            return element;
        }
        
        public static IStyle SetFlexDirection(this IStyle style, FlexDirection flexDirection)
        {
            style.flexDirection = flexDirection;
            return style;
        }
        #endregion
    }
}