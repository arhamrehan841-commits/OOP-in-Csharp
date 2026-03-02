using System.Linq;
using Store.Extensions;

namespace Store.CartItems;

public class RunScript
{
    public static void Main()
    {
        // CartItem Item1 = new CartItem("Iphone 15",500.000m);
        // CartItem Item2 = new CartItem("Iphone 16",600.000m);
        // CartItem Item3 = new CartItem("Iphone 17",700.000m);

        // ShoppingCart MyCart = new ShoppingCart();

        // MyCart.AddItem(Item1);
        // MyCart.AddItem(Item2);
        // MyCart.AddItem(Item3);

        // Console.WriteLine(MyCart.GetPremiumItems().Count);

        decimal cartTotal = 1299.99m;

        Console.WriteLine(cartTotal.ToCurrencyStringManual());

    }
}