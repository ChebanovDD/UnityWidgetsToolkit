using Extensions;
using UnityEngine;
using UnityEngine.UIElements;

namespace Widgets
{
    public enum Icons
    {
        None,
        Plus,
        Minus
    }

    public class Icon : Widget
    {
        private const float DefaultSize = 96;

        private readonly Icons _icon;
        private readonly Color _color;
        private readonly float _width;
        private readonly float _height;

        public Icon(
            Icons icon = Icons.None,
            Color color = default,
            float width = DefaultSize,
            float height = DefaultSize
        )
        {
            _icon = icon;
            _color = color == default ? Color.white : color;
            _width = width;
            _height = height;
        }

        public override VisualElement Build()
        {
            if (_icon == Icons.None)
            {
                return this;
            }

            style.width = _width;
            style.height = _height;
            style.backgroundImage.Release();
            style.backgroundImage = new StyleBackground(Resources.Load<Sprite>($"Icons/{_icon}"));
            style.unityBackgroundImageTintColor = _color;

            return this;
        }
    }
}