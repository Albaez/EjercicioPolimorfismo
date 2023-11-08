using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
  
    class Perro : Animal
    {
      
        public override void Comunicarse()
        {
            Console.WriteLine("Guau guau!");
        }

       
        public override void MostrarNombre()
        {
            Console.WriteLine("Soy un perro.");
        }
    }
}
