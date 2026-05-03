namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(101, "Monitor", 3, 75000m));
            Console.WriteLine(p2.CrearResumenVenta(102, "Mouse", 0, 1500m));

            var p3 = new Problema3();
            var producto = new Product("Auriculares");
            Console.WriteLine(p3.CompararCopias(10, producto));

            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));
            Console.WriteLine(p4.CalcularPromedio(null, null, null));
            Console.WriteLine(p4.CalcularPromedio(5, null, 7));
            Console.WriteLine(p4.CalcularPromedio(-1, 8, 11));

            var p5 = new Problema5();
            Console.WriteLine(p5.ObtenerImporteFinal(new RetailSale(10000m)));
            Console.WriteLine(p5.ObtenerImporteFinal(new WholesaleSale(10000m)));
        }
    }
}
