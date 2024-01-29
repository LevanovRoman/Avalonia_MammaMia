// using Avalonia.Controls;
// using Avalonia.Controls.Chrome;
// using Avalonia.Interactivity;
using FluentAvalonia.UI.Windowing;

namespace Avalonia_MammaMia.Views;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();
        TitleBar.ExtendsContentIntoTitleBar = true;
        TitleBar.TitleBarHitTestType = TitleBarHitTestType.Complex;
    }
}