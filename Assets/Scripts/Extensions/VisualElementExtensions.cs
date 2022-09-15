using UnityEngine.UIElements;
using Widgets;

namespace Extensions
{
    public static class VisualElementExtensions
    {
        public static T AddWidget<T>(this T visualElement, Widget widget) where T : VisualElement
        {
            if (widget != null)
            {
                visualElement.Add(widget.Build());
            }

            return visualElement;
        }
    }
}