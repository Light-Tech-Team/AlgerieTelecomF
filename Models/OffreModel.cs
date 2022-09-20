using AlgerieTelecomF.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgerieTelecomF.Models
{
    public class OffreModel : offer, INotifyPropertyChanged
    {
      
        public int Id {
            get { return id; }

            set { id = value; OnPropertyChanged("Id"); }
        
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public string Type
        {

            get { return type; }

            set { type = value; OnPropertyChanged("Type"); }

        }

        public float Cost
        {

            get { return cost;}

            set{cost = value; OnPropertyChanged("Cost"); }
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }


}
