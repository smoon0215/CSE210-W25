public class Product
{
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public double PricePerUnit
    {
        get { return pricePerUnit; }
        set { pricePerUnit = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}