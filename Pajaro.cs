using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    class Pajaro : Animal
    {
       
        public override void Comunicarse()
        {
            Console.WriteLine("Pio pio!");
        }

 
        public override void MostrarNombre()
        {
            Console.WriteLine("Soy un pajaro.");
        }
    }
}
