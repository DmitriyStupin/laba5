using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Student> Students { get; set; }

        public RelayCommand AddNewStudentCommand { get; set; }
        public RelayCommand RemoveStudentCommand { get; set; }

        public StudentViewModel() 
        {
            Students = new ObservableCollection<Student>();
            CurrentStudent = new Student();

            AddNewStudentCommand = new RelayCommand(AddNewStudent);
            RemoveStudentCommand = new RelayCommand(RemoveStudent);
        }

        public Student CurrentStudent { get; set; }
        private StudentViewModel _student;

        public void OnPropertyChanged(string propertyName)
        {

        }

        private void RemoveStudent()
        {
            Students.Remove(CurrentStudent);
            CurrentStudent = new Student();
        }private void AddNewStudent()
        {
            CurrentStudent = new Student();
            Students.Add(CurrentStudent);
        }
    }
}
