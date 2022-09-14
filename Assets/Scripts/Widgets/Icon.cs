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
        private readonly Icons _icon;
        private readonly Color _color;

        public Icon(
            Icons icon = Icons.None,
            Color color = default
        )
        {
            _icon = icon;
            _color = color == default ? Color.white : color;
        }

        public override VisualElement Build()
        {
            if (_icon == Icons.None)
            {
                return this;
            }

            style.width = 96;
            style.height = 96;
            style.backgroundImage.Release();
            style.backgroundImage = new StyleBackground(Resources.Load<Sprite>($"Icons/{_icon}"));
            style.unityBackgroundImageTintColor = _color;

            return this;
        }
    }
}