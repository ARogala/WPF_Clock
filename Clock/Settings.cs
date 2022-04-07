using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Clock
{
    public class Settings : INotifyPropertyChanged
    {
        //private fields
        //set colorChoice to default neon green
        private string colorChoice = "#3bfe04";

        //public property ColorChoice to expose the private field colorChoice safely
        public string ColorChoice
        {
            get { return colorChoice; }
            set { colorChoice = value; OnPropertyChanged("ColorChoice"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        
    }   
}
