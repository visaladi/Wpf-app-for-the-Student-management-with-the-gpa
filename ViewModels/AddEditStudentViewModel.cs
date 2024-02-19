using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_UI_Sachi.Models;
using System;

namespace Desktop_UI_Sachi.ViewModels
{
    public class AddEditStudentViewModel : ObservableObject
    {
        public Student Student { get; set; }

        public RelayCommand SaveCommand { get; }
        public RelayCommand CancelCommand { get; }

        public Action<bool> CloseAction { get; set; }


        public AddEditStudentViewModel(Student student)
        {
            Student = student;

            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
        }

        private void Save()
        {
            // Save the changes to the database or other storage
            // ...

            // Close the window and set the DialogResult to true
            CloseAction?.Invoke(true);
        }


        private void Cancel()
        {
            // Close the window and set the DialogResult to false
            CloseAction?.Invoke(false);
        }

    }
}

