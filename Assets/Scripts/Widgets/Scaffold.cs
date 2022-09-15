using Extensions;
using UnityEngine;
using UnityEngine.UIElements;

namespace Widgets
{
    public class Scaffold : Widget
    {
        private const float DefaultButtonDistance = 64;

        private readonly Widget _body;
        private readonly Color _backgroundColor;
        private readonly Widget _floatingActionButton;
        private readonly float _floatingActionButtonRight;
        private readonly float _floatingActionButtonBottom;

        public Scaffold(
            Widget body = null,
            Color backgroundColor = default,
            Widget floatingActionButton = null,
            float floatingActionButtonRight = DefaultButtonDistance,
            float floatingActionButtonBottom = DefaultButtonDistance
        )
        {
            _body = body;
            _backgroundColor = backgroundColor == default ? default : backgroundColor;
            _floatingActionButton = floatingActionButton;
            _floatingActionButtonRight = floatingActionButtonRight;
            _floatingActionButtonBottom = floatingActionButtonBottom;
        }

        public override VisualElement Build()
        {
            style.backgroundColor = _backgroundColor;
            style.width = style.height = Length.Percent(100);

            if (_floatingActionButton != null)
            {
                _floatingActionButton.style.position = Position.Absolute;
                _floatingActionButton.style.right = _floatingActionButtonRight;
                _floatingActionButton.style.bottom = _floatingActionButtonBottom;
            }

            this.AddWidget(_body);
            this.AddWidget(_floatingActionButton);

            return this;
        }
    }
}