using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_MammaMia.ViewModels;

public partial class ButtonPageViewModel : ViewModelBase 
{
    [ObservableProperty]
    private bool _isButtonEnabled = true;
}