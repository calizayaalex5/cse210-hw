using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private const decimal USA_SHIPPING_COST = 5m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35m;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetShippingCost()
    {
        return _customer.LivesInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
    }

    public decimal GetTotalOrderPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $" - {product.GetProductName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }

    public string GetOrderSummary()
    {
        string summary = $"🛒 Order Summary for {_customer.GetCustomerName()}:\n";
        summary += "---------------------------------\n";
        summary += "Product Details\n";

        decimal subtotal = 0;
        foreach (var product in _products)
        {
            summary += $"{product.GetProductName()} (ID: {product.GetProductID()})\n";
            summary += $" - Unit Price: ${product.GetProductPrice()}\n";
            summary += $" - Quantity {product.GetQuantity()}\n";
            summary += $" - SubTotal: ${product.GetTotalPrice()}\n";
            summary += $"---------------------------------\n";
            subtotal += product.GetTotalPrice();
        }

        decimal shippingcost = GetShippingCost();
        decimal totalCost = GetTotalOrderPrice();
        summary += $"Subtotal: ${subtotal}\n";
        summary += $"Shipping Cost: ${shippingcost}\n";
        summary += $"Total Price: ${totalCost}\n";
        return summary;
    }
}