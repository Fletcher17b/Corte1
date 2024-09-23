using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.Models
{
    internal class Calculo
    {
        public static int calc_edad(DateTime fecha_nac)
        {
            int edad=0;
//            DateTime now = new DateTime();
            DateTime now = DateTime.Now;

            edad = now.Year-fecha_nac.Year;


            return edad;
        }
    }
}
