using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Modelo
{
    internal class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age {  get; set; }

        public void CalcularEdad()
        {
            this.Age= DateTime.Now.Year - this.BirthDate.Year;
        }
    }
}
