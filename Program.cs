using CAPSTONE_Swift_Server.Models;
using CAPSTONE_Swift_Server;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7261",
                                              "http://localhost:3000")
                                               .AllowAnyHeader()
                                               .AllowAnyMethod();
                      });
});


// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<SwiftDbContext>(builder.Configuration["SwiftDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

// API

#region Admin

//app.MapGet("/admin/{uid}", (SwiftDbContext db, string uid) =>
//{
//    var user = db.Administrators.Where(x => x.Uid == uid).ToList();
//    if (uid == null)
//    {
//        return Results.NotFound("Sorry, Cashier not found!");
//    }
//    else
//    {
//        return Results.Ok(user);
//    }
//});

#endregion

#region Customer

#endregion

#region Order

#endregion

#region Product

// View All Products
app.MapGet("/products", (SwiftDbContext db) => {

    return db.Products.ToList();

});

// View A Single Product
app.MapGet("/products/{pId}", (SwiftDbContext db, int pId) => {

    return db.Products.FirstOrDefault(o => o.Id == pId);

});

// Create A Product
app.MapPost("/products/new", (SwiftDbContext db, Product Payload) =>
{

    Product NewProduct = new Product()
    {
        Title = Payload.Title,
        Description = Payload.Description,
        Category = Payload.Category,
        Price = Payload.Price,
        Length = Payload.Length,
        Width = Payload.Width,
        Wheelbase = Payload.Wheelbase,
        SkateSpots = Payload.SkateSpots,
        ImageUrl1 = Payload.ImageUrl1,
        ImageUrl2 = Payload.ImageUrl2,
        ImageUrl3 = Payload.ImageUrl3,
    };

    db.Products.Add(NewProduct);
    db.SaveChanges();
    return Results.Ok();
});

// Update A Product
app.MapPut("/products/update/{pId}", (SwiftDbContext db, int pId, Product payload) => {

    Product SelectedProd = db.Products.FirstOrDefault(o => o.Id == pId);

    SelectedProd.Title = payload.Title;
    SelectedProd.Description = payload.Description;
    SelectedProd.Category = payload.Category;
    SelectedProd.Price = payload.Price;
    SelectedProd.Length = payload.Length;
    SelectedProd.Width = payload.Width;
    SelectedProd.Wheelbase = payload.Price;
    SelectedProd.SkateSpots = payload.SkateSpots;
    SelectedProd.ImageUrl1 = payload.ImageUrl1;
    SelectedProd.ImageUrl2 = payload.ImageUrl2;
    SelectedProd.ImageUrl3 = payload.ImageUrl3;

    db.SaveChanges();
    return Results.Ok("The existing Product has been updated.");
});

// Delete An Product
app.MapDelete("/products/remove/{pId}", (SwiftDbContext db, int pId) => {

    Product SelectedProd = db.Products.FirstOrDefault(o => o.Id == pId);

    db.Products.Remove(SelectedProd);
    db.SaveChanges();
    return Results.Ok("The product has been removed.");

});

// Get Products from an Order

app.MapGet("/orders/{id}/products", (SwiftDbContext db, int id) =>
{
    try
    {
        var SingleOrder = db.Orders
            .Where(db => db.Id == id)
            .Include(Order => Order.ProductList)
            .ToList();

        if (SingleOrder == null)
        {
            return Results.NotFound("Sorry for the inconvenience! This order does not exist.");
        }
        return Results.Ok(SingleOrder);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// Add Product to an Order

app.MapPost("/orders/{orderId}/list", (SwiftDbContext db, int orderId, Product payload) =>
{
    // Retrieve object reference of Orders in order to manipulate (Not a query result)
    var order = db.Orders
    .Where(o => o.Id == orderId)
    .Include(o => o.ProductList)
    .FirstOrDefault();

    if (order == null)
    {
        return Results.NotFound("Order not found.");
    }

    order.ProductList.Add(payload);

    db.SaveChanges();

    return Results.Ok(order);

});

// Remove Product from an Order

app.MapDelete("/orders/{orderId}/list/{productId}/remove", (SwiftDbContext db, int orderId, int productId) =>
{
    try
    {
        // Include should come first before selecting
        var SingleOrder = db.Orders
            .Include(Order => Order.ProductList)
            .FirstOrDefault(db => db.Id == orderId);

        if (SingleOrder == null)
        {
            return Results.NotFound("Sorry for the inconvenience! This order does not exist.");
        }
        // The reason why it didn't work before is because I didnt have a method after ProductList
        var SelectedProductList = SingleOrder.ProductList.FirstOrDefault(p => p.Id == productId);
        SingleOrder.ProductList.Remove(SelectedProductList);

        db.SaveChanges();
        return Results.Ok(SingleOrder.ProductList);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

#endregion

#region Review

#endregion





app.Run();

