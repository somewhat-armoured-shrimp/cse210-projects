class Product
{
    private string _name;
    private int _productId;
    private decimal _price; // because MONEY WHO CARES 
    private decimal _quantity; // it didn't like multiplying a 
                               // decimal and int together #stophate
                               
    public Product(string name, int productId, decimal price, decimal quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateTotal()
    {
        return _price * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"#{_productId} - {_name} x {_quantity}\n";
    }
}