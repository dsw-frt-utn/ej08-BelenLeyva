public class Sale
{
    public decimal Amount { get; set; }

    public Sale(decimal amount)
    {
        Amount = amount;
    }

    public virtual decimal CalculateTotal()
    {
        return Amount;
    }
}

public class RetailSale : Sale
{
    public RetailSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal()
    {
        return Amount; // sin descuento
    }
}

public class WholesaleSale : Sale
{
    public WholesaleSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal()
    {
        return Amount * 0.90m; // 10% de descuento
    }
}