using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class FrutasAcidas : Frutas
    {
        public bool TieneSemillas { get; set; }
        public bool EsDulce { get; set; }
        public bool EsAcido { get; set; }


        public override void Imprimir()
        {
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"TieneSemillas: {ValidarAtributo(TieneSemillas)}");
            Console.WriteLine($"EsDulce: {ValidarAtributo(EsDulce)}");
            Console.WriteLine($"EsAcido: {ValidarAtributo(EsAcido)}");
        }

        public override string ValidarAtributo(bool Valor)
        {
            return Valor ? "Si" : "No"; ;
        }
    }
}
