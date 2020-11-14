using Practice.Command;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Practice.ViewModels
{
    class NewStudentVM : MainWindowVM, IDataErrorInfo
    {
        private int _StudentID;
        private string _FirstName;
        private string _LastName;
        private DateTime _Birthdate = DateTime.Now;
        private bool _Gender;
        private string _Address;
        private string _Email;
        private string _class;

 
        public int StudentID { get => _StudentID; set => _StudentID = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public DateTime Birthdate { get => _Birthdate; set => _Birthdate = value; }
        public bool Gender { get => _Gender; set => _Gender = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Class { get => _class; set => _class = value; }
        public Student NewStu { get; set; }


        public NewStudentVM()
        {
            ButtonSave = new RelayCommand(o => Save(), o => !(StudentID <= 0)
             && !string.IsNullOrEmpty(FirstName)
             && !string.IsNullOrEmpty(LastName)
             && !(Birthdate > DateTime.Now));
        }

        public string GetGender(bool Check)
        {
            if (Check)
            {
                return "Male";
            }
            return "Female";
        }
        public void SetConvert(string Gen)
        {
            if (Gen == "Male")
                Gender = true;
            else
                Gender = false;
        }



        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;

                if (nameof(StudentID) == columnName)
                {
                    if (StudentID <= 0)
                    {
                        result = "Student ID is mandatory & not Negaive and Different";
                    }
                }



                if (nameof(FirstName) == columnName)
                {
                    if (string.IsNullOrEmpty(FirstName))
                    {
                        result = "First Name is mandatory";
                    }
                }


           
                if (nameof(LastName) == columnName)
                {
                    if (string.IsNullOrEmpty(LastName))
                    {
                        result = "Last Name is mandatory";
                    }
                }
 


                if (nameof(Birthdate) == columnName)
                {
                    if (Birthdate > DateTime.Now)
                    {
                        result = "Please select day is less than date now";
                    }
                }
       

                return result;
            }
        }
        public string Error => throw new NotImplementedException();



        public ICommand ButtonSave { get; set; }
        public void Save()
        {
            NewStu = new Student
            {
                StudentID = StudentID,
                FirstName = FirstName,
                LastName = LastName,
                Birthdate = Birthdate,
                Gender = GetGender(Gender),
                Address = Address,
                Email = Email,
                Class = Class,
            };

            StudentService.Add(NewStu);
        }

        public ICommand ButtonCancel { get; set; }
        public void Cancel()
        {
            Window window = new MainWindow();
            Application.Current.Shutdown();
        }
    }
}
