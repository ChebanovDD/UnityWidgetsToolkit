using UnityEngine.UIElements;

namespace Widgets
{
    public class SizedBox : Widget
    {
        private readonly float _width;
        private readonly float _height;

        public SizedBox(float width = 0, float height = 0)
        {
            _width = width;
            _height = height;
        }
        
        public override VisualElement Build()
        {
            style.width = _width;
            style.height = _height;

            return this;
        }
    }
}