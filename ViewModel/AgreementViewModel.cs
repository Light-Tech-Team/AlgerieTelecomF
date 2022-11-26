using AlgerieTelecomF.Entity;
using AlgerieTelecomF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgerieTelecomF.ViewModel
{
    public class AgreementViewModel
    {
        List<AgreementModel> agrmodel = new List<AgreementModel>();
        List<AgreementEntity> agrentity = new List<AgreementEntity>();

        public AgreementViewModel()
        {
            agrentity.Add(new AgreementEntity{ name = "Ordinaire",remise=1});
            agrentity.Add(new AgreementEntity { name = "Police", remise = 0.5f });
            agrentity.Add(new AgreementEntity { name = "Civil Protection", remise = 0.5f });
            agrentity.Add(new AgreementEntity { name = "Militaire", remise = 0.5f });
            agrentity.Add(new AgreementEntity { name = "Teacher", remise = 0.5f });

            foreach (AgreementEntity c in agrentity)
            {

                agrmodel.Add(new AgreementModel() { Name = c.name, Remise = c.remise });
            }



        }
        public List<AgreementModel> GetAgreement()
        {

           


            return agrmodel;    
        }

        public void SetAgreement(AgreementModel agreement)
        {
            agrmodel.Add(new AgreementModel{Name = agreement.Name , Remise = agreement.Remise });


        }



    }
}
