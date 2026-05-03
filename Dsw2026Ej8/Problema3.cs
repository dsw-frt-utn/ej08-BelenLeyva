public class Problema3
{
	public string CompararCopias(int originalValue, Product product)
	{
		
		int copia = originalValue;
		copia++;

		Product productoCopia = product;
		productoCopia.ModificarDescripcion("Descripcion modificada");

		return $"{originalValue}-{copia}-{product.Description}";
	}
}