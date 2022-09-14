using UnityMvvmToolkit.Core;

public class CounterViewModel : ViewModel
{
    private int _count;
    private string _header = "Widgets UI Toolkit";

    public int Count
    {
        get => _count;
        set => Set(ref _count, value);
    }

    public string Header
    {
        get => _header;
        set => Set(ref _header, value);
    }
}