using CustomerCatalogMinimalAPI.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<List<Customer>>();

var app = builder.Build();
app.UseHttpsRedirection();

// Define routes and handlers for CRUD operations
app.MapGet("/api/customers", (List<Customer> customers) => customers);

app.MapGet("/api/customers/{id}", (int id, List<Customer> customers) => customers.FirstOrDefault(p => p.Id == id));

app.MapPost("/api/customers", (Customer customer, List<Customer> customers) =>
{
    customers.Id = customers.Count + 1;
    customers.Add(customer);
    return Results.Created($"/api/products/{customer.Id}", customer);
});
/*
app.MapPut("/api/customers/{id}", (int id, Customer customer, List<Customer> customer) =>
{
    var existingProduct = customers.FirstOrDefault(p => p.Id == id);
    if (existingProduct == null) return Results.NotFound();
    customer.Id = id;
    customer[customers.IndexOf(existingProduct)] = customer;
    return Results.NoContent();
});
*/


app.MapDelete("/api/products/{id}", (int id, List<Customer> customers) =>
{
    var customer = customers.FirstOrDefault(p => p.Id == id);
    if (customer == null) return Results.NotFound();
    customers.Remove(customer);
    return Results.NoContent();
});

app.Run();