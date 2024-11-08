using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class UIElementExtensions
    {
        #region ---------------Classes---------------
        public static T AddClasses<T>(this T element, params string[] classNames)
            where T : VisualElement
        {
            foreach (string className in classNames)
            {
                element.AddToClassList(className);
            }
            return element;
        }
        #endregion
    }
}
