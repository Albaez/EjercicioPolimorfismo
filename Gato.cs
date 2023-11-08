using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    class Gato : Animal
    {
       
        public override void Comunicarse()
        {
            Console.WriteLine("Miau miau!");
        }

       
        public override void MostrarNombre()
        {
            Console.WriteLine("Soy un gato.");
        }
    }

}
