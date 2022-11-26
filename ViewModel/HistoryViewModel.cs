using AlgerieTelecomF.Entity;
using AlgerieTelecomF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace AlgerieTelecomF.ViewModel
{
   public class HistoryViewModel 
    {
       List<HistoryEntity> entities = new List<HistoryEntity>();
       public  List<HistoryModel> modelh = new List<HistoryModel>();
       
        List <OffreModel> ofremodel = new List<OffreModel>();
        public List<int> listphone = new List<int>();

        public HistoryViewModel()
        {


            



            }

        public void setHistory(HistoryModel mdl)
        {


        }

        public List<HistoryModel> GetHistory(int histphone)
        {


            modelh.Add(new HistoryModel() { Offrenameh = History.offrenameh , Offretypeh = History.offretypeh,Agreementname =History.agreementname,Resident=History.resident,Numberline = History.principaleline});

            return modelh;

        }


        public IEnumerable<int> GetNumber()
        {
            var query = from item in modelh select item.Numberline;
           

            return query;
        }

       /* public List<int> GetEmptyNumber()
        {
            var query = from item in entities select item.principaleline;


            return query.ToList();

        }*/



        public void UpdateNumber(int numberline)
        {


        }

        // class end 
    }






       

        /*   public List<int> GetNumber()
           {

               foreach(HistoryEntity c in entities)
               {
                   return c.principaleline;
               }

           }*/


      

    }


