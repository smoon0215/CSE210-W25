public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.InUSA() ? 5.0 : 35.0;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }

    public List<Product> Products
    {
        get { return _products; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }
}
