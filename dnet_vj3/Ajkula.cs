using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnet_vj3
{
    class Ajkula : Riba
    {
        public Ajkula()
        {
            this._datumUlova = DateTime.Now;
        }

        public DateTime _datumUlova;
        

        public int ProsloOdUlova()
        {
            DateTime a = DateTime.Now;
            DateTime b = _datumUlova;
            return (a - b).Days;
        }

        enum VrstaAjkule
        {
            VelikiBijeli,
            Tigar, 
            Morgulj,
        }
    }
}
