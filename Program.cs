using CAPSTONE_Swift_Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using CAPSTONE_Swift_Server;
using EFCore.NamingConventions;
using System.Security.Cryptography;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000",
                                              "https://localhost:7261")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<SwiftDbContext>(builder.Configuration["SwiftDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

// API

// Get All Users

#region Users

app.MapGet("/users", (SwiftDbContext db) =>
{
    return db.Users.ToList();
});

// Get Single Users by Id

app.MapGet("/users/byIden/{cId}", (SwiftDbContext db, int cId) =>
{
    return db.Users.FirstOrDefault(x => x.Id == cId);
});

//// Get Single Users by UID

app.MapGet("/users/auth/{uId}", (SwiftDbContext db, string uId) =>
{
    var User = db.Users.FirstOrDefault(x => x.Uid == uId);

    if (User == null)
    {
        return Results.NotFound("Sorry, Customer not found!");
    }
    else
    {
        return Results.Ok(User);
    }
});

// Register New User
app.MapPost("/register", (SwiftDbContext db, User payload) =>
{
    User NewUser = new User()
    {
        Name = payload.Name,
        Bio = payload.Bio,
        Email = payload.Email,
        PhoneNumber = payload.PhoneNumber,
        ImageUrl = payload.ImageUrl,
        Uid = payload.Uid,
        IsAdmin = payload.IsAdmin,
    };

    db.Users.Add(NewUser);
    db.SaveChanges();
    return Results.Ok(NewUser.Name);
});

// Update User
app.MapPut("/users/update/{uid}", (SwiftDbContext db, string uid, User NewUser) =>
{
    User SelectedUser = db.Users.FirstOrDefault(x => x.Uid == uid);
    if (SelectedUser == null)
    {
        return Results.NotFound("This customer is not found in the database. Please Try again!");
    }

    SelectedUser.Name = NewUser.Name;
    SelectedUser.Email = NewUser.Email;
    SelectedUser.PhoneNumber = NewUser.PhoneNumber;
    SelectedUser.ImageUrl = NewUser.ImageUrl;
    db.SaveChanges();
    return Results.Created("/users/update/{uid}", SelectedUser);

});

#endregion

#region Order

// View All Orders
app.MapGet("/orders", (SwiftDbContext db) => {

    return db.Orders.ToList();

});

// View A Single Order
app.MapGet("/orders/{oId}", (SwiftDbContext db, int oId) => {

    return db.Orders.FirstOrDefault(o => o.Id == oId);

});


// Create New Order
app.MapPost("/orders/new", (SwiftDbContext db, Order Payload) =>
{

    Order NewOrder = new Order()
    {
        CustomerName = Payload.CustomerName,
        CustomerEmail = Payload.CustomerEmail,
        CustomerPhoneNumber = Payload.CustomerPhoneNumber,
        StreetAddress = Payload.StreetAddress,
        Country = Payload.Country,
        TownCity = Payload.TownCity,
        State = Payload.State,
        Zipcode = Payload.Zipcode,
        DateTime = Payload.DateTime,
        Revenue = Payload.Revenue,
        PaymentId = Payload.PaymentId,
        OrderStatusId = Payload.PaymentId,
        ShippingMethod = Payload.ShippingMethod,
    };

    db.Orders.Add(NewOrder);
    db.SaveChanges();
    return Results.Ok();
});

// Update Order
app.MapPut("/orders/update/{oId}", (SwiftDbContext db, int oId, Order Payload) => {

    Order SelectedOrder = db.Orders.FirstOrDefault(o => o.Id == oId);

    SelectedOrder.CustomerName = Payload.CustomerName;
    SelectedOrder.CustomerEmail = Payload.CustomerEmail;
    SelectedOrder.CustomerPhoneNumber = Payload.CustomerPhoneNumber;
    SelectedOrder.StreetAddress = Payload.StreetAddress;
    SelectedOrder.Country = Payload.Country;
    SelectedOrder.TownCity = Payload.TownCity;
    SelectedOrder.State = Payload.State;
    SelectedOrder.Zipcode = Payload.Zipcode;
    SelectedOrder.DateTime = Payload.DateTime;
    SelectedOrder.Revenue = Payload.Revenue;
    SelectedOrder.PaymentId = Payload.PaymentId;
    SelectedOrder.OrderStatusId = Payload.PaymentId;

    db.SaveChanges();
    return Results.Ok("The existing order has been updated.");
});

// Delete An Order
app.MapDelete("/orders/remove/{oId}", (SwiftDbContext db, int oId) => {

    Order SelectedOrder= db.Orders.FirstOrDefault(o => o.Id == oId);

    db.Orders.Remove(SelectedOrder);
    db.SaveChanges();
    return Results.Ok("Order has been removed.");

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
        AdminId = Payload.AdminId,
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

    SelectedProd.AdminId = payload.AdminId;
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

#region Cart

// View Products in Cart by UID
app.MapGet("/cart/{UID}", (SwiftDbContext db, string UID ) => {

    //return db.Carts.FirstOrDefault(o => o.CustomerUid == UID);
    var CartProductList =
          from x in db.Carts
          where x.CustomerUid == UID
          select x.ProductList;

    if (CartProductList == null)
    {
        return Results.NotFound("Cart doesn't exist!");
    }

    return Results.Ok(CartProductList);
});

//Create A Cart

app.MapPost("/cart/new", (SwiftDbContext db, string UID) =>
{
    var CartExists = db.Carts.FirstOrDefault(x => x.CustomerUid == UID);

    if (CartExists == null)
    {
        Cart NewProduct = new Cart()
        {
            CustomerUid = UID,
        };

        db.Carts.Add(NewProduct);
        db.SaveChanges();

        return Results.Created("Cart User created:", NewProduct.CustomerUid);
    }

    return Results.Conflict("A cart already exists for this user.");
});

// Add Products to Cart

app.MapPost("/cart/list", (SwiftDbContext db, string UID, Product payload) =>
{
    var CartUser = db.Carts
    .Where(c => c.CustomerUid == UID)
    .Include(c => c.ProductList)
    .FirstOrDefault();

    if (CartUser == null)
    {
        return Results.NotFound("Cart not found.");
    }

    CartUser.ProductList.Add(payload);

    db.SaveChanges();

    return Results.Ok(CartUser.ProductList);

});

// Remove All From Cart 

app.MapDelete("/cart/delete/all", (SwiftDbContext db, string UID) =>
{
    var SelectedUserCart = db.Carts
    .Where(c => c.CustomerUid == UID)
    .Include(c => c.ProductList)
    .FirstOrDefault();

    if (SelectedUserCart == null)
    {
        return Results.NotFound("I'm sorry! This users cart is empty.");
    }

    SelectedUserCart.ProductList.Clear();
    db.SaveChanges();
    return Results.Ok("The Cart has been wiped!");
});

// Remove A Single Product from Cart

app.MapDelete("/cart/delete", (SwiftDbContext db, string UID, int productId) =>
{
    try
    {
        // Include should come first before selecting
        var SingleCart = db.Carts
            .Include(c => c.ProductList)
            .FirstOrDefault(c => c.CustomerUid == UID);

        if (SingleCart == null)
        {
            return Results.NotFound("Sorry for the inconvenience! This Cart does not exist.");
        }
        // The reason why it didn't work before is because I didnt have a method after ProductList
        var SelectedProductList = SingleCart.ProductList.FirstOrDefault(p => p.Id == productId);
        if (SelectedProductList == null)
        {
            return Results.NotFound("Product does not exist in this List");
        }

        SingleCart.ProductList.Remove(SelectedProductList);

        db.SaveChanges();
        return Results.Ok(SingleCart.ProductList);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});


#endregion

#region Review

// View All Reviews
app.MapGet("/reviews", (SwiftDbContext db) => {

    return db.Reviews.ToList();

});

// View A Single Review
app.MapGet("/reviews/{rId}", (SwiftDbContext db, int rId) => {

    return db.Reviews.FirstOrDefault(o => o.Id == rId);

});

// Create A Review
app.MapPost("/reviews/new", (SwiftDbContext db, Review Payload) =>
{

    Review NewReview = new Review()
    {
        Content = Payload.Content,
    };

    db.Reviews.Add(NewReview);
    db.SaveChanges();
    return Results.Ok();
});

// Update A Review
app.MapPut("/reviews/update/{rId}", (SwiftDbContext db, int rId, Review payload) => {

    Review SelectedReview = db.Reviews.FirstOrDefault(o => o.Id == rId);

    SelectedReview.Content = payload.Content;

    db.SaveChanges();
    return Results.Ok("The existing review has been updated.");

});

// Delete A Review
app.MapDelete("/reviews/remove/{rId}", (SwiftDbContext db, int rId) => {

    Review SelectedReview = db.Reviews.FirstOrDefault(o => o.Id == rId);

    db.Reviews.Remove(SelectedReview);
    db.SaveChanges();
    return Results.Ok("The review has been removed.");

});

// Get Reviews from a Product

app.MapGet("/products/{id}/reviews", (SwiftDbContext db, int id) =>
{
    try
    {
        var ProdReviewList = db.Products
            .Where(db => db.Id == id)
            .Include(p => p.ReviewList)
            .ToList();

        if (ProdReviewList == null)
        {
            return Results.NotFound("Sorry for the inconvenience! This order does not exist.");
        }
        return Results.Ok(ProdReviewList);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// Add Review to an Product

app.MapPost("/products/{pId}/add", (SwiftDbContext db, int pId, Review payload) =>
{
    // Retrieve object reference of Orders in order to manipulate (Not a query result)
    var ProdReviewList = db.Products
    .Where(o => o.Id == pId)
    .Include(o => o.ReviewList)
    .FirstOrDefault();

    if (ProdReviewList == null)
    {
        return Results.NotFound("Order not found.");
    }

    ProdReviewList.ReviewList.Add(payload);

    db.SaveChanges();

    return Results.Ok(ProdReviewList);

});

// Remove Review from an Product

app.MapDelete("/products/{pId}/reviewlist/{rId}/remove", (SwiftDbContext db, int pId, int rId) =>
{
    try
    {
        // Include should come first before selecting
        var SingleProduct = db.Products
            .Include(p => p.ReviewList)
            .FirstOrDefault(db => db.Id == pId);

        if (SingleProduct == null)
        {
            return Results.NotFound("Sorry for the inconvenience! This order does not exist.");
        }
        // The reason why it didn't work before is because I didnt have a method after ProductList
        var SelectedProductList = SingleProduct.ReviewList.FirstOrDefault(r => r.Id == rId);
        SingleProduct.ReviewList.Remove(SelectedProductList);

        db.SaveChanges();
        return Results.Ok(SingleProduct.ReviewList);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

#endregion


app.Run();

