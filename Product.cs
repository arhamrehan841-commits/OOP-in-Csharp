namespace Store.Models; // Note the semicolon (File-scoped namespace)

public class Product {
    public string Name{get;private set;} // Convention: Public fields/properties use PascalCase
    public decimal Price{get;private set;} // Use decimal for money, not double!

    public Product(string name, decimal price) {

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty");

        if (price<1)
            throw new ArgumentException("Price cannot be 0 or negative.");    

        Name = name;
        Price = price;
    }

    public virtual decimal CalculateTax()
    {
        return Price * 0.10m;
    }

}


public class PhysicalProduct : Product {
    
    public decimal WeightInKg{get;private set;}

    public PhysicalProduct(string name,decimal price,decimal weightInKg) : base (name,price)
    {
        WeightInKg = weightInKg;
    }

}

public class DigitalProduct : Product {
    
    public string DownloadUrl{get;private set;}

    public DigitalProduct(string name,decimal price,string downloadUrl) : base (name,price)
    {
        DownloadUrl = downloadUrl;
    }

    public override decimal CalculateTax()
    {
        return 0m;
    }

}