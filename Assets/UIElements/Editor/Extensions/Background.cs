using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Background---------------

        public static T SetBg<T>(this T element, Texture2D image)
            where T : VisualElement
        {
            element.style.SetBg(image);
            return element;
        }
        
        public static IStyle SetBg(this IStyle style, Texture2D image)
        {
            style.backgroundImage = image;
            return style;
        }

        #endregion

        #region ---------------Background Color---------------
        public static T SetBgColor<T>(this T element, Color color)
            where T : VisualElement
        {
            element.style.SetBgColor(color);
            return element;
        }

        public static IStyle SetBgColor(this IStyle style, Color color)
        {
            style.backgroundColor = color;
            return style;
        }
        #endregion
    }
}