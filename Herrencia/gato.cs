using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //Sintaxis Herencia
    // Tipo de acceso class _NombreClaseDerivada_ : _NombreClaseBase_
    internal class Gato :Mamífero
    {
        //Atributos
        private int nBigotes { get; set; }

        //Constructor
        /* Cuando se hereda un constructor con parámetros
         * se tienen que colocar los parámetros en el constructor
         * de la clase derivada (o subclase), de lo contrario
         * se mantendrá un error
         */
        public Gato(string n, double p, int b) : base(n, p)
        {
            this.nBigotes = b;
        }

        //Metodos 
        public void mostrarGato()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
            Console.WriteLine("Tiene " + nBigotes + " bigotes completos");
        }
    }
}