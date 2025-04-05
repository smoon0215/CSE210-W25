public class Order{
    
        private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize Order with a Customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product) => _products.Add(product);

    // Method to calculate total cost of the order (including shipping)
    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        // Shipping cost based on customer's location
        double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
        return totalProductCost + shippingCost;
    }

    // Method to generate the packing label for the order
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    // Method to generate the shipping label for the order
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}
