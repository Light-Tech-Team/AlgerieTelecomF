
using AlgerieTelecomF.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AlgerieTelecomF.Models;

namespace AlgerieTelecomF.ViewModel
{
    internal class ClientViewModel 

    {

        ClientModelcs modelcs = new ClientModelcs();
        public ClientEntity entities = new ClientEntity();

        List<ClientModelcs> listmodel = new List<ClientModelcs>();
        List<ClientEntity> listentities = new List<ClientEntity>();




        public ClientViewModel()
        {
            //  فلاسك = ent http
            entities.code = 1;
            entities.firstName="ZAKARIA";
            entities.lastName="basbas";
            entities.birthDay=new DateTime(1998,02,25);
            entities.cardId=230214565;
            entities.cardDate = new DateTime(2016,04,14); 
            entities.phone = 0665651107;


         }
        public List<ClientModelcs> listPhone()
        {
            
                listmodel.Add(new ClientModelcs() { Phone = 33394355  });
                listmodel.Add(new ClientModelcs() { Phone = 33394506 });
                listmodel.Add(new ClientModelcs() { Phone = 33394355 });
                listmodel.Add(new ClientModelcs() { Phone = 33394355 });
            



            return listmodel;
        }



        public ClientModelcs models()
        {
          modelcs.Code = entities.code;
            modelcs.FirstName = entities.firstName  ;
            modelcs.LastName = entities.lastName  ;
            modelcs.BirthDay = entities.birthDay ;
            modelcs.CardId = entities.cardId ;
            modelcs.CardDate = entities.cardDate  ;
           modelcs.Phone =  entities.phone;
           
            return modelcs;
        }
       


        public void Updateclient(ClientModelcs modelcs)
        {

             entities.code = modelcs.Code;
             entities.firstName = modelcs.FirstName;
             entities.lastName = modelcs.LastName;
             entities.birthDay = modelcs.BirthDay;
             entities.cardId = modelcs.CardId;
             entities.cardDate = modelcs.CardDate;
             entities.phone = modelcs.Phone;


        }



        public void DeleteNumber(int i)
        { }



    }
}
