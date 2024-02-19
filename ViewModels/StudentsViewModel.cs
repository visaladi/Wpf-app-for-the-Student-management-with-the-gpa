using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_UI_Sachi.Models;
using Desktop_UI_Sachi.Views;
using System;
using System.Collections.ObjectModel;

namespace Desktop_UI_Sachi.ViewModels
{
    public class StudentsViewModel : ObservableObject
    {
        private Student? _selectedStudent;

        public ObservableCollection<Student> Students { get; set; }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                SetProperty(ref _selectedStudent, value);
                EditStudentCommand.NotifyCanExecuteChanged();
                DeleteStudentCommand.NotifyCanExecuteChanged();
            }
        }

        public RelayCommand AddStudentCommand { get; }
        public RelayCommand EditStudentCommand { get; }
        public RelayCommand DeleteStudentCommand { get; }

        public StudentsViewModel()
        {
            // Initialize the collection with some dummy data
            Students = new ObservableCollection<Student>
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    ImageThumbnail = $"/Images/1.png",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    GPA = 3.5
                },
                new Student
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    ImageThumbnail = $"/Images/2.png",
                    DateOfBirth = new DateTime(2001, 2, 2),
                    GPA = 3.8
                }
            };

            AddStudentCommand = new RelayCommand(AddStudent);
            EditStudentCommand = new RelayCommand(EditStudent, () => SelectedStudent != null);
            DeleteStudentCommand = new RelayCommand(DeleteStudent, () => SelectedStudent != null);
        }

        private void AddStudent()
        {
            // Create a new student object
            var newStudent = new Student();

            // Show the Add/Edit Student window
            var addEditWindow = new AddEditStudentView(newStudent);
            var result = addEditWindow.ShowDialog();

            // Add the new student to the collection if the user clicked "Save" and entered a first name
            if (result.HasValue && result.Value && !string.IsNullOrWhiteSpace(newStudent.FirstName))
            {
                Students.Add(newStudent);
            }
        }


        private void EditStudent()
        {
            // Show the Add/Edit Student window with the selected student's data
            var addEditWindow = new AddEditStudentView(SelectedStudent);
            addEditWindow.ShowDialog();
        }

        private void DeleteStudent()
        {
            // Remove the selected student from the collection
            Students.Remove(SelectedStudent);
        }
    }
}
