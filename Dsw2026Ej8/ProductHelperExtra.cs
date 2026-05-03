
public partial class ProductHelper
{
    private const string Formato = "C";

    private string FormatearPrecio(decimal price)
    {
        return price.ToString(Formato);
    }
}