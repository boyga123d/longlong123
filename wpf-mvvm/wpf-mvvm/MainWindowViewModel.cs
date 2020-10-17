using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _name;
        private string _helloText;

        

        public string Name {
            get
            {
                return _name;
            }
            set{
                _name = value;
                HelloText = $"Hello {_name}";
            }
        }

        public string HelloText { get { return _helloText; }
            set {
                _helloText = value;
                OnPropertyChanged(nameof(HelloText));
            }
        }
    }
}
