using System.Text;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Contents:");
        foreach (var product in _products)
        {
            label.AppendLine($"{product.Name} (ID: {product.ProductID})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Ship To:");
        label.AppendLine(_customer.Name);
        label.AppendLine(_customer.Address.GetFullAddress());
        return label.ToString();
    }
}