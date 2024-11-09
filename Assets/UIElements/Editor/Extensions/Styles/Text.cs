using UnityEngine.UIElements;
using UnityEngine.TextCore.Text;
using UnityEditor;
using UnityEngine;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Font Size---------------
        public static T FontSize<T>(this T element, float size, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.FontSize(size, unit);
            return element;
        }

        public static IStyle FontSize(this IStyle style, float size, LengthUnit unit = LengthUnit.Pixel)
        {
            style.fontSize = new Length(size, unit);
            return style;
        }
        #endregion

        #region ---------------Font Style---------------
        public static T FontStyle<T>(this T element, UnityEngine.FontStyle unityFontStyle)
            where T : VisualElement
        {
            element.style.FontStyle(unityFontStyle);
            return element;
        }

        public static IStyle FontStyle(this IStyle style, UnityEngine.FontStyle unityFontStyle)
        {
            style.unityFontStyleAndWeight = unityFontStyle;
            return style;
        }
        #endregion

        #region ---------------Font Def---------------
        public static T FontDef<T>(this T element, string sdf_fontPath)
            where T : VisualElement
        {
            element.style.FontDef(sdf_fontPath);
            return element;
        }

        public static IStyle FontDef(this IStyle style, string sdf_fontPath)
        {
            FontAsset sdf_FontAsset = AssetDatabase.LoadAssetAtPath<FontAsset>(sdf_fontPath);
            style.unityFontDefinition = FontDefinition.FromSDFFont(sdf_FontAsset);
            return style;
        }
        #endregion
        
        #region ---------------Font Color---------------
        public static T FontColor<T>(this T element, Color color)
            where T : VisualElement
        {
            element.style.FontColor(color);
            return element;
        }

        public static IStyle FontColor(this IStyle style, Color color)
        {
            style.color = new StyleColor(color);
            return style;
        }
        #endregion
    }
}