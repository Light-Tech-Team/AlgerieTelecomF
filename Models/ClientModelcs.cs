using AlgerieTelecomF.Entity;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgerieTelecomF.Models
{
    public class ClientModelcs : Clients, INotifyPropertyChanged
       
    
 
    
   
    

    {
       public int Code
    {
            get { return code; }

            set { code = value; OnPropertyChanged("Code"); }

        }

     public string FirstName
    {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }

      public string LastName
    {

            get { return lastName; }

            set { lastName = value; OnPropertyChanged("LastName"); }

        }

    public DateTime BirthDay
    {

            get { return birthDay; }

            set { birthDay = value; OnPropertyChanged("BirthDay"); }
        }
    public int CardId
    {

        get { return cardId; }

        set { cardId = value; OnPropertyChanged("CardId"); }
    }

    public DateTime CardDate
    {

        get { return cardDate; }

        set { cardDate = value; OnPropertyChanged("CardDate"); }
    }

        public string Email
        {

            get { return email; }

            set { email = value; OnPropertyChanged("Email"); }
        }

        public int Phone
    {

        get { return phone; }

        set { phone = value; OnPropertyChanged("Phone"); }
    }




    public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
