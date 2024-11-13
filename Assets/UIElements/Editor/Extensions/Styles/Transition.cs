using System.Collections.Generic;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class StyleExtensions
    {
        public static void SetTransitions(this VisualElement element, List<string> properties, float duration, string easing = "ease", float delay = 0f)
        {
            element.style.transitionProperty = new StyleList<StylePropertyName>(properties.ConvertAll(p => new StylePropertyName(p)));
            element.style.transitionDuration = new StyleList<TimeValue>(new List<TimeValue> { new TimeValue(duration, TimeUnit.Second) });
            element.style.transitionTimingFunction = new StyleList<EasingFunction>(new List<EasingFunction> { new EasingFunction((EasingMode)System.Enum.Parse(typeof(EasingMode), easing)) });
            element.style.transitionDelay = new StyleList<TimeValue>(new List<TimeValue> { new TimeValue(delay, TimeUnit.Second) });
        }
    }
}
