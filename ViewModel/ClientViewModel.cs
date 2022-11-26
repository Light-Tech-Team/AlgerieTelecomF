
using AlgerieTelecomF.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AlgerieTelecomF.Models;
using System.Net.Http;

namespace AlgerieTelecomF.ViewModel
{
    public class ClientViewModel 

    {
        HttpClient htp = new HttpClient(); 

        public ClientModelcs modelcs = new ClientModelcs();
        

       public List<ClientModelcs> listmodel = new List<ClientModelcs>();
       public  List<ClientEntity> listentities = new List<ClientEntity>();




        public ClientViewModel()
        {
            //  فلاسك = ent http
            

           //string sr = new string();

        // sr=htp.GetAsync("127.1.1.0//");




         }
     



        public ClientModelcs GetClient(int Code)
        {
            modelcs.FirstName = Clients.firstName;
            modelcs.Email = Clients.email;
            modelcs.Phone = Clients.phone;
            modelcs.BirthDay = Clients.birthDay;
            modelcs.CardDate = Clients.cardDate;

            return modelcs;
        }
       


        public void Updateclient()
        {

            modelcs.FirstName = Clients.firstName;
            modelcs.Email = Clients.email;
            modelcs.BirthDay = Clients.birthDay;
            modelcs.Phone = Clients.phone;
            modelcs.CardDate = Clients.cardDate;
            modelcs.CardId = Clients.cardId;


        }



        public void DeleteNumber(int phone)
        { 
        
        }

        public ClientModelcs setClient()
        {
           
            modelcs.FirstName = Clients.firstName;
           
            modelcs.BirthDay = Clients.birthDay;
            modelcs.CardId = Clients.cardId;
            modelcs.CardDate = Clients.cardDate;
            modelcs.Phone = Clients.phone;

            return modelcs ;

        }

    }
}
