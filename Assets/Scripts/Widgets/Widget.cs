using UnityEngine.UIElements;

namespace Widgets
{
    public abstract class Widget : VisualElement
    {
        public abstract VisualElement Build();
    }
}