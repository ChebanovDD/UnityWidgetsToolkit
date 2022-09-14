using Extensions;
using UnityEngine.Device;
using UnityEngine.UIElements;

namespace Widgets
{
    public class SafeArea : Widget
    {
        private readonly Widget _child;

        public SafeArea(
            Widget child = null
        )
        {
            _child = child;
        }

        public override VisualElement Build()
        {
            var safeArea = Screen.safeArea;

            // TODO: Bottom & Right

            style.marginTop = safeArea.y;
            style.marginLeft = safeArea.x;
            style.width = style.height = Length.Percent(100);

            this.AddWidget(_child);

            return this;
        }
    }
}