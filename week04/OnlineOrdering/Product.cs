public class Product
{
    private string _productName;
    private int _productID;
    private decimal _productPrice;
    private int _quantity;

    public Product (string productName, int productID, decimal productPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _productPrice * _quantity;
    }

    public string GetProductName() => _productName;
    public int GetProductID() => _productID;
    public decimal GetProductPrice() => _productPrice;
    public int GetQuantity() => _quantity;
}