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
using System.Windows.Media;

namespace AlgerieTelecomF.ViewModel
{
    internal class HistoryViewModel : INotifyPropertyChanged
    {
       List<HistoryEntity> entities = new List<HistoryEntity>();
        List<HistoryModel> model = new List<HistoryModel>();
       
        List <OffreModel> ofremodel = new List<OffreModel>();

        public HistoryViewModel()
        { 
           
            entities.Add(new HistoryEntity { id = 1, date = new DateTime(2022, 09, 12),
                offrenameh = "Idoom", offretypeh = "4Mbp/s", agreementname = "Police",
                principaleline = 33394343,resident = "Rue Ben Badis",
                
            });
            entities.Add(new HistoryEntity
            {
                id = 1,
                date = new DateTime(2022, 09, 12),
                offrenameh = "Idoom",
                offretypeh = "4Mbp/s",
                agreementname = "Police",
                principaleline = 33394343,
                resident = "Rue Ben Badis",
              
                
            });
            entities.Add(new HistoryEntity
            {
                id = 1,
                date = new DateTime(2022, 09, 12),
                offrenameh = "Idoom",
                offretypeh = "4Mbp/s",
                agreementname = "Police",
                principaleline = 33394343,
                resident = "Rue Ben Badis",
                
                
            });


            foreach (HistoryEntity c in entities)
            {
                model.Add(new HistoryModel()
                {
                    Id = c.id++,
                    Date = c.date,
                    Offrenameh = c.offrenameh,
                    Offretypeh = c.offretypeh,
                    Agreementname = c.agreementname,
                    Numberline = c.principaleline,
                    Resident = c.resident
                });
            }

        }
        
        


   

        public void setmodels(HistoryModel mdl)
        {
            model.Add(mdl);

        }

        public List<HistoryModel> listmodels()
        {

            return model;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
