using ProductCatalog;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Product p1 = new Product{ ProductId = 12, ProductName = "Mama Earth", ProductPrice = 89.01};
Product p2 = new Product{ ProductId = 22, ProductName = "Coka Earth", ProductPrice = 89.01};
Product p3 = new Product{ ProductId = 33, ProductName = "Poka Earth", ProductPrice = 89.01};
Product p4 = new Product{ ProductId = 55, ProductName = "Pappa Earth", ProductPrice = 89.01};
Product p5 = new Product{ ProductId = 63, ProductName = "Earth Earth", ProductPrice = 89.01};

List<Product> products = new List<Product>();

products.Add(p1);
products.Add(p2);
products.Add(p3);
products.Add(p4);
products.Add(p5);

try {
    // Serialization
    var options = new JsonSerializerOptions {IncludeFields = true};
    var productsJson = JsonSerializer.Serialize<List<Product>>(products, options);
    string fileName = @"C:\.NET\dotnet\Day5\product.json";
    File.WriteAllText(fileName, productsJson);
    // Serialize all product into json file

    // Deserialization
    string jsonString = File.ReadAllText(fileName);
    List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
    foreach(Product p in jsonProducts){
        Console.Write($"{p.ProductId} : {p.ProductName}");
    }
}
catch(Exception exp){
    Console.WriteLine("Message : "+exp);
}
finally{
    
}

