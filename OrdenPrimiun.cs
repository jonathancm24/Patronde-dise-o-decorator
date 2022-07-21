using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrdenPrimiun : Decorador
    {
        public OrdenPrimiun(OrdenBase orden): base(orden) { }

        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine($"Calculo del precio total en la clase {nameof(OrdenPrimiun)}.");
            var prOrdenprecio =base.CalcularTotalPrecioOrden();

            Console.WriteLine("Adicion de un descuento adicional al precio anticipado");
            return prOrdenprecio * 0.9;
        }
    }
}
