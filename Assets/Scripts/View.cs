using UnityEngine.UIElements;
using Widgets;

public abstract class View<TBindingContext> : VisualElement where TBindingContext : new()
{
    protected View()
    {
        RegisterCallback<GeometryChangedEvent>(OnLayoutCalculated);
    }

    protected abstract Widget Build(TBindingContext context);

    private void OnLayoutCalculated(GeometryChangedEvent e)
    {
        UnregisterCallback<GeometryChangedEvent>(OnLayoutCalculated);
        
        style.width = style.height = Length.Percent(100);
        
        Add(Build(new TBindingContext()).Build());
    }
}