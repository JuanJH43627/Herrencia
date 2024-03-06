using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Ballena : Mamífero

    {
        //Constructor
        public Ballena(string n, double p) : base(n, p)
        {
        }
        
        //Metotos
        public void mostrarballena ()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es:"+ nom);
            Console.WriteLine("Su peso en kg es de:"+ peso +"kg");
        }
            
            



    }
}
