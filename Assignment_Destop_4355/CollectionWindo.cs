
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assignment_Destop_4355
{
    public partial class CollectionWindow : ObservableObject
    {


        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student? edit_student = null;




        [RelayCommand]
        public void RemoveStudent()
        {
            if (edit_student != null)
            {
                string name = edit_student.FirstName;
                students.Remove(edit_student);
                MessageBox.Show($"{name} is Deleted successfuly");

            }
            else
            {
                MessageBox.Show("Please Select Student");


            }
        }

        [RelayCommand]
        public void AddStudent()
        {



            var newWindow = new NewWindowVM();

            newWindow.title = "ADD STUDENT";
            NewWindow window = new NewWindow(newWindow);
            window.ShowDialog();

            if (newWindow.addStudent.FirstName != null)

            {
                students.Add(newWindow.addStudent);
            }
            else
            {

                MessageBox.Show("Please enter the student details!!");
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (edit_student != null)
            {
                var newWindow = new NewWindowVM(edit_student);
                newWindow.title = "EDIT STUDENT";
                var window = new NewWindow(newWindow);

                window.ShowDialog();


                int index = students.IndexOf(edit_student);
                students.RemoveAt(index);
                students.Insert(index, newWindow.addStudent);



            }
            else
            {
                MessageBox.Show("Please Select the student");
            }
        }

        public CollectionWindow()
        {
            students = new ObservableCollection<Student>();
            students.Add(new Student(22, "Mark", "Antony", "2000/12/01","3.5", "1.png"));
            students.Add(new Student(23, "Manic", "Basha", "1999/02/11",    "3.6", "10.png"));
            students.Add(new Student(22, "Jhon", "Wick", "2000/11/21",  "3.4", "3.png"));
            students.Add(new Student(21, "Paul", "Walker", "2001/03/03", "3.5", "7.png"));
            students.Add(new Student(23, "Tom", "Crush", "1999/10/08","3.1", "8.png"));
            students.Add(new Student(22, "Michel", "Jackson", "2000/04/01", "3.7", "2.png"));

        }



    }
}
