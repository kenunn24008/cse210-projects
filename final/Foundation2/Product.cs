class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public string Name => _name;
    public string ProductID => _productID;

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}