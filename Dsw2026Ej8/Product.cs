public class Product
{
    public string Description { get; set; }

    public Product(string description)
    {
        Description = description;
    }

    public void ModificarDescripcion(string nuevaDescripcion)
    {
        Description = nuevaDescripcion;
    }
}