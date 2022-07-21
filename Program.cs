// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

var regularOrden = new OrdenRegular();
Console.WriteLine(regularOrden.CalcularTotalPrecioOrden());
Console.WriteLine();

var preOrden = new PreOrden();
Console.WriteLine(preOrden.CalcularTotalPrecioOrden());
Console.WriteLine();

var ordenPrimiun = new OrdenPrimiun(preOrden);
Console.WriteLine(ordenPrimiun.CalcularTotalPrecioOrden());
Console.WriteLine();




