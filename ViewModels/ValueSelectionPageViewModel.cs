using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_MammaMia.ViewModels;

public partial class ValueSelectionPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isValueSelectionEnabled = true;

    [ObservableProperty]
    private int _sliderValue;
}