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

            
        }
    }
}
