//string[] names = { "Tom", "Harry", "Mary", "Jay" };

//var query = names.Where(n => n.Contains("a"))
//    .OrderBy(n => n.Length)
//    .Select(n => n.ToUpper());

//foreach (string name in query)
//{
//    Console.WriteLine(name);
//}

IList<Product> products = new List<Product>
{
    new Product
    {
        ProductId = 1,
        ProductName = "Laptop",
        Price = 999.99m,
        Category = "Electronics",
        Stock = 50
    },
    new Product
    {
        ProductId = 2,
        ProductName = "Smartphone",
        Price = 699.99m,
        Category = "Electronics",
        Stock = 150
    },
    new Product
    {
        ProductId = 3,
        ProductName = "Desk Chair",
        Price = 89.99m,
        Category = "Furniture",
        Stock = 85
    },
    new Product
    {
        ProductId = 4,
        ProductName = "Book: C# Programming",
        Price = 39.99m,
        Category = "Books",
        Stock = 200
    },
    new Product
    {
        ProductId = 5,
        ProductName = "Wireless Mouse",
        Price = 25.99m,
        Category = "Electronics",
        Stock = 120
    }
};

//Find all product price greater than 100

var expensiveProducts = products.Where(p => p.Price > 100);

foreach (var product in expensiveProducts)
{
    Console.WriteLine($"ID: {product.ProductId}" +
        $"Name: {product.ProductName}" +
        $"Price: {product.Price}" +
        $"Category: {product.Category}" +
        $"Srock: {product.Stock}"
        );
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
}