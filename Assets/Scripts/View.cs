using System.ComponentModel;
using Extensions;
using UnityEngine.UIElements;
using Widgets;

public abstract class View<TBindingContext> : VisualElement where TBindingContext : INotifyPropertyChanged, new()
{
    protected View()
    {
        RegisterCallback<GeometryChangedEvent>(OnLayoutCalculated);
    }

    protected abstract Widget Build(TBindingContext context);

    private void OnLayoutCalculated(GeometryChangedEvent e)
    {
        try
        {
            style.width = style.height = Length.Percent(100);
            this.AddWidget(Build(new TBindingContext()));
        }
        finally
        {
            UnregisterCallback<GeometryChangedEvent>(OnLayoutCalculated);
        }
    }
}