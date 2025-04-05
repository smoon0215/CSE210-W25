public class Product
{
    public string Name {get; set;}
    public string ProductId {get; set;}

    public double PricePerUnit {get; set;}

    public int Quantity {get; set;}


    public Product(string name, string productId, double pricePerUnit, int quantity){

        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalCost() => PricePerUnit * Quantity;
}