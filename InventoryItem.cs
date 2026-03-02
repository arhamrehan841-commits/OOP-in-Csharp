using System;

namespace Store.Warehouse;

public class InventoryItem
{
    public string Sku{get;private set;}

    public int Quantity;

    public decimal WholesaleCost;

    public InventoryItem(string sku,int quantity,decimal wholesalecost)
    {
        Sku = sku;
        Quantity = quantity;
        WholesaleCost = wholesalecost;
    }

    public decimal GetTotalValue()
    {
        return Quantity*WholesaleCost;
    }

}