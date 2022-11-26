using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgerieTelecomF.Models
{
    public class HistoryModel : History
    {


        public int Id
        {
            get { return id; }
            set { id = value; }

        }


        public DateTime Date
        {
            get { return date; }
            set { date = value; }

        }

        public string Offrenameh
        {
            get { return offrenameh; }
            set { offrenameh = value; }

        }

        public string Offretypeh
        {
            get { return offretypeh; }
            set { offretypeh = value; }

        }

        public string Agreementname
        {
            get { return agreementname; }
            set { agreementname = value; }

        }

        public int Numberline
        {
            get { return principaleline; }
            set { principaleline = value; }

        }

        public string Resident
        {
            get { return resident; }
            set { resident = value; }

        }

        
        public string Serviceline
        {
            get { return         serviceline; }
            set { serviceline = value; }

        }




    }
}
