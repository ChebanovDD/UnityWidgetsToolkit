using UnityEngine.UIElements;
using Widgets;

namespace Extensions
{
    public static class VisualElementExtensions
    {
        public static T AddChild<T>(this T visualElement, Widget child) where T : VisualElement
        {
            if (child != null)
            {
                visualElement.Add(child.Build());
            }

            return visualElement;
        }
    }
}