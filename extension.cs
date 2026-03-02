namespace Store.Extensions;

public static class DecimalExtensions
{
    public static string ToCurrencyStringManual(this decimal amount)
    {
        return amount.ToString("C");
    }
}