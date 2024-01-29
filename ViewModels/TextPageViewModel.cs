using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_MammaMia.ViewModels;

public partial class TextPageViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isTextEnabled = true;
}