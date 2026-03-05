# OOP Concepts Demonstration in C#

Simple console application to show core **Object-Oriented Programming** principles in C# (.NET 8).

## Concepts demonstrated

- **Encapsulation** — private fields + public properties
- **Inheritance** — `InventoryItem` likely extends `Product`
- **Composition** — Shopping cart contains items
- **(Possibly) Polymorphism / Abstraction** — depending on `Payment` and extension methods

## Files overview

- `Product.cs`              Base product information
- `InventoryItem.cs`        Stock / inventory entry
- `CartItem.cs`             Single item in shopping cart
- `ShoppingCartItem.cs`     (possibly duplicate or variant of CartItem — consider merging later)
- `Payment.cs`              Payment handling logic
- `Extensions.cs`           Helper / extension methods
- `Program.cs`              Application entry point and demo

## How to run

```bash
git clone https://github.com/arhamrehan841-commits/OOP-in-Csharp.git

cd OOP-in-Csharp

dotnet restore

dotnet run
```

## Requirements

.NET 8.0 SDK

## Next steps (planned)

Merge CartItem + ShoppingCartItem if redundant
Add interfaces (e.g. IPaymentProcessor)
Add unit tests