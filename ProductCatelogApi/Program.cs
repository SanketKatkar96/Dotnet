using Catlog;
using System.Collections.Generic;

 var builder =WebApplication.CreateBuilder(args);
 var app =builder.Build();

app.MapGet("/api/customers", () =>{return  "tanvi, nikita, sachin";});
app.MapGet("/api/cart", () =>{return  "laptop-2, samsung-6, earbuds-8";});
app.MapGet("/api/orders", () =>{return  "ord123, ord432, ord987";});
app.MapGet("/api/products", () =>{return ProductService.GetAll();});
app.MapPost("/api/products",()=>{ return ProductService.Insert();});
app.Run();

