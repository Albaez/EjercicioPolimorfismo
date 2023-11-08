using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Animal[] animales = new Animal[3];


            animales[0] = new Perro();
            animales[1] = new Gato();
            animales[2] = new Pajaro();

            
            foreach (Animal animal in animales)
            {
              
                animal.Comunicarse();
                animal.MostrarNombre();
                Console.WriteLine("");
            }

        }
    }
}
