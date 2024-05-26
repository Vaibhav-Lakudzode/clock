using CustomersWebAPI.Entities;
using Microsoft.VisualBasic;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//HTTP request handler functions mapping

app.MapGet("/products", () =>
{
    var products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Price = 25 },
        new Product { Id = 2, Name = "Product 2", Price = 35 },
        new Product { Id = 3, Name = "Product 3", Price = 456 }
    };
    return products;
});
app.MapGet("/posts/ravi", () =>
{
    List<Seller> sellers = new List<Seller>
    {
        new Seller { Name = "Vaibhav lakudzode", Email = "Vaibhav@gmail.com" },
        new Seller { Name = "Sagar Pawar", Email = "sagar5445@gmail.com" },
    };
    Buyer myBlog = new Buyer { Name = "amit", Email = "amit45145@gmail.com", Sellers = sellers };
    return myBlog;
});


app.Run();