class Product
{
    public string Name { get; set; }
    public int ProductID { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int id, double price, int quantity)
    {
        Name = name;
        ProductID = id;
        Price = price;
        Quantity = quantity;
    }

    public double CalculatePrice()
    {
        return Price * Quantity;
    }
}