using Extensions;
using UnityEngine.UIElements;

namespace Widgets
{
    public class Stack : Widget
    {
        private readonly Widget[] _children;
        private readonly FlexDirection _flexDirection;

        public Stack(Widget[] children = null, FlexDirection flexDirection = default)
        {
            _children = children;
            _flexDirection = flexDirection;
        }

        public override VisualElement Build()
        {
            style.flexDirection = _flexDirection;
        
            if (_children == null)
            {
                return this;
            }

            foreach (var child in _children)
            {
                this.AddChild(child);
            }

            return this;
        }
    }
}