using UnityEngine;
using UnityEngine.UIElements;

namespace Widgets
{
    public class Text : Widget
    {
        private readonly string _name;
        private readonly string _text;
        private readonly float _fontSize;
        private readonly Color _fontColor;
        private readonly TextAnchor _textAlign;

        private Label _label;

        public Text(
            string name = nameof(Text),
            string text = default,
            float fontSize = 12,
            Color fontColor = default,
            TextAnchor textAlign = TextAnchor.MiddleLeft
        )
        {
            _name = name;
            _text = text;
            _fontSize = fontSize;
            _textAlign = textAlign;
            _fontColor = fontColor == default ? Color.black : fontColor;
        }

        public void SetText(string text)
        {
            _label.text = text;
        }

        public override VisualElement Build()
        {
            name = _name;

            _label = new Label(_text)
            {
                style =
                {
                    color = _fontColor,
                    fontSize = _fontSize,
                    unityTextAlign = _textAlign
                }
            };

            Add(_label);

            return this;
        }
    }
}