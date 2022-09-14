using Extensions;
using UnityEngine;
using UnityEngine.UIElements;

namespace Widgets
{
    public class Scaffold : Widget
    {
        private readonly Widget _body;
        private readonly Color _backgroundColor;
        private readonly Widget _floatingActionButton;

        public Scaffold(
            Widget body = null,
            Color backgroundColor = default,
            Widget floatingActionButton = null
        )
        {
            _body = body;
            _backgroundColor = backgroundColor == default ? default : backgroundColor;
            _floatingActionButton = floatingActionButton;
        }

        public override VisualElement Build()
        {
            style.backgroundColor = _backgroundColor;
            style.width = style.height = Length.Percent(100);

            if (_floatingActionButton != null)
            {
                _floatingActionButton.style.position = Position.Absolute;
                _floatingActionButton.style.right = 64;
                _floatingActionButton.style.bottom = 64;
            }

            this.AddWidget(_body);
            this.AddWidget(_floatingActionButton);

            return this;
        }
    }
}