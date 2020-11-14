using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.ViewModel
{
    class StudentViewModel : BaseViewModel, IDataErrorInfo
    {
        private string _StudentId;
        private string _FirstName;
        private string _LastName;
        private DateTime _Birthday = DateTime.Now;
        private string _Gender;
        private string _Address;
        private string _Email;
        private string _Class;
        private List<string> _ListClass = new List<string> { "18A", "18B" };
        private bool _Male;
        private bool _Female;
        public string StudentId { get => _StudentId; set => _StudentId = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Class { get => _Class; set => _Class = value; }
        public List<string> ListClass { get => _ListClass; set => _ListClass = value; }
        public bool Male { get => _Male; set => _Male = value; }
        public bool Female { get => _Female; set => _Female = value; }

        public ICommand ViewCommand { get; set; }
        public void View()
        {

        }

        public ICommand SaveCommand { get; set; }
        public void Save()
        {

        }

        public ICommand CancelCommand { get; set; }
        public void Cancel()
        {

        }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (nameof(StudentId) == columnName)
                {
                    if (string.IsNullOrEmpty(StudentId))
                    {
                        result = "Student id is mandatory";
                    }
                }
                if (nameof(FirstName) == columnName)
                {
                    if (string.IsNullOrEmpty(FirstName))
                    {
                        result = "First name is mandatory";
                    }
                }
                if (nameof(LastName) == columnName)
                {
                    if (string.IsNullOrEmpty(LastName))
                    {
                        result = "Last name is mandatory";
                    }
                }
                if (nameof(Address) == columnName)
                {
                    if (string.IsNullOrEmpty(Address))
                    {
                        result = "Address is mandatory";
                    }
                }
                if (nameof(Email) == columnName)
                {
                    if (string.IsNullOrEmpty(Email))
                    {
                        result = "Email is mandatory";
                    }
                }
                if (nameof(Class) == columnName)
                {
                    if (string.IsNullOrEmpty(Class))
                    {
                        result = "Class is mandatory";
                    }
                }
                return result;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }


    }
}
