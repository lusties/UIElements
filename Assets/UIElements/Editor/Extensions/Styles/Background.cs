using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Background---------------

        public static T BgImage<T>(this T element, Texture2D image)
            where T : VisualElement
        {
            element.style.BgImage(image);
            return element;
        }
        
        public static IStyle BgImage(this IStyle style, Texture2D image)
        {
            style.backgroundImage = image;
            return style;
        }

        #endregion

        #region ---------------Background Color---------------
        public static T BgColor<T>(this T element, Color color)
            where T : VisualElement
        {
            element.style.BgColor(color);
            return element;
        }

        public static IStyle BgColor(this IStyle style, Color color)
        {
            style.backgroundColor = color;
            return style;
        }
        #endregion
    }
}