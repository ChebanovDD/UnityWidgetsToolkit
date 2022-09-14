using System;
using Extensions;
using UnityEngine.UIElements;

namespace Widgets
{
    public class FloatingActionButton : Widget
    {
        private readonly Widget _child;
        private readonly Action _onPressed;

        public FloatingActionButton(Widget child = null, Action onPressed = null)
        {
            _child = child;
            _onPressed = onPressed;
        }

        public override VisualElement Build()
        {
            var borderRadius = Length.Percent(50);

            var button = new Button
            {
                style =
                {
                    width = 192,
                    height = 192,
                    borderTopLeftRadius = borderRadius,
                    borderTopRightRadius = borderRadius,
                    borderBottomLeftRadius = borderRadius,
                    borderBottomRightRadius = borderRadius,
                    alignItems = Align.Center,
                    justifyContent = Justify.Center
                }
            };

            button.AddChild(_child);

            if (_onPressed != null)
            {
                button.clicked += _onPressed;
            }

            Add(button);
        
            return this;
        }
    }
}