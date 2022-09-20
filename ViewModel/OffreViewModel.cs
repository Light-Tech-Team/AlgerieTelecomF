using AlgerieTelecomF.Entity;
using AlgerieTelecomF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;

namespace AlgerieTelecomF.ViewModel
{
    public class OffreViewModel 
    {

        List<OffreModel> model=new List<OffreModel>(); 

        List<OffreEntity> entities = new List<OffreEntity>();
        


      public OffreViewModel()
        {
            //  فلاسك = ent http
            
            entities.Add(new OffreEntity{id=1,name="Idoom",type="4mb/s",cost=1625 });
            entities.Add(new OffreEntity { id = 1, name = "Idoom", type = "10mb/s", cost = 1625 });
            entities.Add(new OffreEntity { id = 1, name = "Idoom", type = "15mb/s", cost = 1625 });
            entities.Add(new OffreEntity { id = 1, name = "Idoom", type = "20mb/s", cost = 1625 });
            entities.Add(new OffreEntity { id = 1, name = "4g", type = "60Gb/M", cost = 1625 });
            entities.Add(new OffreEntity { id = 1, name = "4g", type = "100Gb/M", cost = 1625 });


            

        }

          public List<OffreModel> listmodels()
         { 
              foreach (OffreEntity c in entities)
                    {
                model.Add(new OffreModel() { Id = c.id, Name = c.name, Type = c.type , Cost = c.cost }) ;
                    }
           
            
           
            return model; 
          }       


        public void addmodel(string name,string type, float cost)
        {
            entities.Add(new OffreEntity { id = 1, name = name, type = type, cost = cost });
            model.Clear();

        }






    }
}
