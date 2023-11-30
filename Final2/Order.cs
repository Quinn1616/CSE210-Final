class Order
{
    public List<Product> Products { get; set; }
    public Customer CustomerInfo { get; set; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        CustomerInfo = customer;
    }

    public double CalculateFinalCost()
    {
        double finalCost = 0;
        foreach (var product in Products)
        {
            finalCost += product.CalculatePrice();
        }

        if (CustomerInfo.InUS())
        {
            finalCost += 5;
        }

        else
        {
            finalCost += 35;
        }

        return finalCost;
    }

    public List<string> GetPackingLabel()
    {
        List<string> productIDs = new List<string>();
        foreach (var product in Products)
        {
            productIDs.Add(product.Name);
            productIDs.Add(product.ProductID.ToString());
        }
        return productIDs;
    }

    public string GetShippingLabel()
    {
        return $"{CustomerInfo.Name}\n{CustomerInfo.AddressLocation.GetAddress()}";
    }
}