using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal abstract class Frutas
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Tamano { get; set; }
        public string Familia { get; set; }

        public abstract void Imprimir();

        public abstract string ValidarAtributo(bool Valor);
    }
}

