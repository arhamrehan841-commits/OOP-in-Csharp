using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks.Dataflow;

namespace Store.Payments;

public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card for {amount}");
        return true;
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Redirecting to PayPal for {amount}");
        return true;
    }
}

public class CheckOutService
{
    public void CompleteCheckout(IPaymentProcessor processor, decimal orderTotal)
    {
        bool success = processor.ProcessPayment(orderTotal);

        if (success)
        {
            Console.WriteLine("Order Complete!");
        }
        else
        {
            Console.WriteLine("Payment failed.");
        }
    }
}

// public class Implementation
// {
//     public static void Main()
//     {
//         CheckOutService checkOut = new CheckOutService();

//         IPaymentProcessor myProcessor = new PayPalProcessor();

//         checkOut.CompleteCheckout(myProcessor,150.00m);
//     }
// }