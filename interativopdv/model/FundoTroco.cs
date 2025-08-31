using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class FundoTroco
    {
        private int idChangeFund;
        private Double startValue;
        private Double endValue;
        private DateTime data = new DateTime();


        public int IdChangeFund
        { get { return idChangeFund; }
          set { idChangeFund = value; }
        }
        public Double StartValue
        {
            get { return startValue; }
            set { startValue = value; }
        }
        public Double EndValue
        {
            get { return endValue; }
            set { endValue = value; }
        }
        public DateTime Data
        {   get { return data; }
            set { data = value; }
        }
    }
}
