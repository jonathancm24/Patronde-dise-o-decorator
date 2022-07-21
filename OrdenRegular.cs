using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class OrdenRegular : OrdenBase
    {
        public override double CalcularTotalPrecioOrden()
        {
            
           Console.WriteLine("Calculo del precio total de un pedido normal");
           return Productos.Sum(x => x.Precio);
            
        }
    }
}
