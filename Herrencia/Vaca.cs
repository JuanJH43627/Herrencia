using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vaca : Mamífero
    {
        private int litrosleche { get; set; }


        //Constructor
        public Vaca(string n, double p, int L) : base(n, p)
        {
            this.litrosleche = L;
        }

        //Métodos
        public void mostra()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es:" + nom);
            Console.WriteLine("Suma el peso en kg es de:" + peso + "kg");
            Console.WriteLine("Los litros de leche generados fue " + litrosleche);
        }

        public void comida()
        {
            double comida = 0;
            comida = (peso / litrosleche);
            Console.WriteLine("La comida ingerida por la vaca fue:" + comida + "kg");
        }

        internal void mostrarVaca()
        {
            throw new NotImplementedException();
        }

        internal void Comida()
        {
            throw new NotImplementedException();
        }
    }
}
