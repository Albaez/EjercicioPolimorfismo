using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{

  
    abstract class Animal
    {
      
        public abstract void Comunicarse();

       
        public virtual void MostrarNombre()
        {
            Console.WriteLine("Soy un animal.");
        }
    }
}
   