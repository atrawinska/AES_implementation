using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CyberSecurityProject.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    [ObservableProperty]
    private string phrase = "";

    [RelayCommand]
    private void Translate()
    {
        //jkf
    }
}
