// See https://aka.ms/new-console-template for more information
using Builder;
using System.Net;
using System.Numerics;

Console.WriteLine("Hello, World!");

BurgerBuilder builder;

Shop shop = new Shop();

builder = new CheeseBurgerBuilder();
shop.Construct(builder);
builder.Burger.Show();

builder = new ChickenBurgerBuilder();
shop.Construct(builder);
builder.Burger.Show();
// Wait for user
Console.ReadKey();


