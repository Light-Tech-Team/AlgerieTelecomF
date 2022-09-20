using AlgerieTelecomF.Superclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace AlgerieTelecomF.Models
{
    public class AgreementModel : Agreement, INotifyPropertyChanged
    {
        public string Name
            {
            get { return name; }

            set { name = value; OnPropertyChanged("Name"); }
        }

        public float Remise
        {
            get { return remise; }

            set { remise = value; OnPropertyChanged("Remise"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
