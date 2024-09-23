using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.Models
{
    internal class Registro
    {
        public Persona[] array_persona = new Persona[30];

        public void input(int index, string name, string last_name, DateTime fecha_nac, string ciudad)
        {
            Persona temp = new Persona();
            temp.name = name;
            temp.last_name = last_name;
            temp.fecha_nac = fecha_nac;
            temp.ciudad = ciudad;   
            array_persona[index] = temp;
            // investigar funcion para destruir objetos
        }
    }
}
