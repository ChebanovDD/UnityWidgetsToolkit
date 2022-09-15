using System;
using Extensions;
using UnityEngine.UIElements;

namespace Widgets
{
    public class FloatingActionButton : Widget
    {
        private const float DefaultSize = 192;

        private readonly Widget _child;
        private readonly Action _onPressed;
        private readonly float _width;
        private readonly float _height;

        public FloatingActionButton(
            Widget child = null,
            Action onPressed = null,
            float width = DefaultSize,
            float height = DefaultSize
        )
        {
            _child = child;
            _onPressed = onPressed;
            _width = width;
            _height = height;
        }

        public override VisualElement Build()
        {
            var borderRadius = Length.Percent(50);

            var button = new Button
            {
                style =
                {
                    width = _width,
                    height = _height,
                    borderTopLeftRadius = borderRadius,
                    borderTopRightRadius = borderRadius,
                    borderBottomLeftRadius = borderRadius,
                    borderBottomRightRadius = borderRadius,
                    alignItems = Align.Center,
                    justifyContent = Justify.Center
                }
            };

            if (_onPressed != null)
            {
                button.clicked += _onPressed;
            }

            button.AddWidget(_child);
            Add(button);

            return this;
        }
    }
}