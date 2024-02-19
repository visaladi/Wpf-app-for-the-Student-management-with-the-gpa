using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Desktop_UI_Sachi.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public StudentsViewModel StudentsViewModel { get; set; }

        public MainWindowViewModel()
        {
            StudentsViewModel = new StudentsViewModel();
        }
    }
}
