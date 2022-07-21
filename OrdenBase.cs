using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class OrdenBase
    {
        protected List<productos> Productos = new List<productos>
        {
            new productos{Nombre ="Telefono", Precio = 300},
            new productos{Nombre = "Tablet", Precio = 800},
            new productos{Nombre = "PC Gamer", Precio = 1800},
            new productos{Nombre = "Laptop", Precio = 1700}
        };
        public abstract double CalcularTotalPrecioOrden();
    }
}
