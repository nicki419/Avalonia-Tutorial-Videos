using ReactiveUI;

namespace Project.GUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel() {
        MainApp = new MainAppViewModel();
        NewView = new NewViewModel();
        contentViewModel = MainApp;
    }

    private ViewModelBase contentViewModel;
    public ViewModelBase ContentViewModel {
        get => contentViewModel;
        set => this.RaiseAndSetIfChanged(ref contentViewModel, value);
    }
    public MainAppViewModel MainApp;
    public NewViewModel NewView;

    public void ChangeView() {
        ContentViewModel = NewView;
    }
}
