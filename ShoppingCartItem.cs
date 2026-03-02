using System;

namespace Store.Cart;

public class ShoppingCartItem
{
    public string ProductName{get;private set;} = string.Empty;

    private int _Quantity;
    public int Quantity
    {
        get => _Quantity;
        set => _Quantity = value < 1 ? 1 : value ;
    }

    private decimal _UnitPrice;
    public decimal UnitPrice{get=>_UnitPrice;set=>_UnitPrice=value<0?0:value;}

    public decimal TotalPrice=>_Quantity*_UnitPrice;

}