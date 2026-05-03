namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema 2
            Console.WriteLine("=== Problema 2 - Resumen de Venta ===");
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(101, "Monitor", 3, 75000m));
            Console.WriteLine(p2.CrearResumenVenta(102, "Mouse", 0, 1500m));

            // Problema 3
            Console.WriteLine("\n=== Problema 3 - Valor vs Referencia ===");
            var p3 = new Problema3();
            var producto = new Product("Auriculares");
            Console.WriteLine(p3.CompararCopias(10, producto));

            // Problema 4
            Console.WriteLine("\n=== Problema 4 - Promedio de Notas ===");
            var p4 = new Problema4();
            Console.WriteLine("Notas 8,6,10: " + p4.CalcularPromedio(8, 6, 10));
            Console.WriteLine("Todas null: " + p4.CalcularPromedio(null, null, null));
            Console.WriteLine("Notas 5,null,7: " + p4.CalcularPromedio(5, null, 7));
            Console.WriteLine("Notas -1,8,11: " + p4.CalcularPromedio(-1, 8, 11));

            // Problema 5
            Console.WriteLine("\n=== Problema 5 - Polimorfismo ===");
            var p5 = new Problema5();
            Console.WriteLine("RetailSale: " + p5.ObtenerImporteFinal(new RetailSale(10000m)));
            Console.WriteLine("WholesaleSale: " + p5.ObtenerImporteFinal(new WholesaleSale(10000m)));

            // Problema 6
            Console.WriteLine("\n=== Problema 6 - Normalizar Codigo ===");
            var p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
            Console.WriteLine(p6.NormalizarCodigoProducto(null!));
        }
    }
}
