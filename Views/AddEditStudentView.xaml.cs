using Desktop_UI_Sachi.Models;
using Desktop_UI_Sachi.ViewModels;
using System.Windows;

namespace Desktop_UI_Sachi.Views
{
    /// <summary>
    /// Interaction logic for AddEditStudentView.xaml
    /// </summary>
    public partial class AddEditStudentView : Window
    {
        public AddEditStudentView(Student student)
        {
            InitializeComponent();
            var viewModel = new AddEditStudentViewModel(student);
            viewModel.CloseAction = (bool result) =>
            {
                DialogResult = result;
                Close();
            };
            DataContext = viewModel;
        }


    }
}
