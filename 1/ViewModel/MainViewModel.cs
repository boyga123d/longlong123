using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private string _textBox;
        private string _Class;
        private List<string> _ListClass = new List<string> { "18A", "18B" };
        public string TextBox { get => _textBox; set => _textBox = value; }
        public string Class { get => _Class; set => _Class = value; }
        public List<string> ListClass { get => _ListClass; set => _ListClass = value; }

        public ICommand SearchCommand { get; set; }
        public void Search()
        {

        }

        public ICommand ResetCommand { get; set; }
        public void Reset()
        {

        }


    }

}
