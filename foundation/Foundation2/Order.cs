class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CalculateShippingCost() // float for consistency? idc
    {
        decimal shippingCost = CalculateProductsCost();

        if (_customer.LivesInUS())
        {
            return shippingCost + 5;
        }
        else
        {
            return shippingCost + 35;
        }
    }
    public decimal CalculateProductsCost()
    {
        decimal productTotal = 0;

        foreach (Product product in _products)
        {
            productTotal += product.CalculateTotal();
        }

        return productTotal;
    }
    public string GetPackingLabel()
    {   
        string packingLabel = "";

        foreach (Product product in _products)
        {   
            ///////// IMPORTANT ///////////////////////////////
            // USE += to MAKE SURE THE THINGS ARE ALL COUNTED 
            // AND NOT JUST THE LAST ONE 
            ///////////////////////////////////////////////////
            packingLabel += product.GetPackingLabel();
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }

}