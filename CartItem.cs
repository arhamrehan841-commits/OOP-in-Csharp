using System.Linq;

namespace Store.CartItems;

public class CartItem
{
    public string _productName{get;private set;}

    public decimal Price {get;private set;}


    public CartItem(string productName,decimal price)
    {
        if (string.IsNullOrWhiteSpace(productName))
        {
            throw new ArgumentException("Product name can not be empty.");
        }
        if (price<=0)
        {
            throw new ArgumentException("Price cannot be negative.");
        }

        _productName = productName;
        Price = price;
    }
}

public class ShoppingCart
{
    private List<CartItem> _items = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        _items.Add(item);
    }

    public decimal CalculateGrandTotal()
    {
        return _items.Sum(p=>p.Price);
    }

    public List<CartItem> GetPremiumItems()
    {
        return _items.Where(p=>p.Price>550.00m).ToList();
    }
}