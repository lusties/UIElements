using UnityEngine.UIElements;
using UnityEngine.TextCore.Text;
using UnityEditor;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Font Size---------------
        public static T SetFontSize<T>(this T element, float size, LengthUnit unit = LengthUnit.Pixel)
            where T : VisualElement
        {
            element.style.SetFontSize(size, unit);
            return element;
        }

        public static IStyle SetFontSize(this IStyle style, float size, LengthUnit unit = LengthUnit.Pixel)
        {
            style.fontSize = new Length(size, unit);
            return style;
        }
        #endregion

        #region ---------------Font Style---------------

        #endregion

        #region ---------------Font Def---------------
        public static T SetFontDef<T>(this T element, string sdf_fontPath)
            where T : VisualElement
        {
            element.style.SetFontDef(sdf_fontPath);
            return element;
        }

        public static IStyle SetFontDef(this IStyle style, string sdf_fontPath)
        {
            FontAsset sdf_FontAsset = AssetDatabase.LoadAssetAtPath<FontAsset>(sdf_fontPath);
            style.unityFontDefinition = FontDefinition.FromSDFFont(sdf_FontAsset);
            return style;
        }
        #endregion
    }
}