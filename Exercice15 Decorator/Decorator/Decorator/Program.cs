// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");


static void printIceCreamFlavors(Sushi sushi)
{
    Console.WriteLine("Le sushi a en goût: " + sushi.getFlavors());
}

Sushi sushi = new SimpleSushi();
printIceCreamFlavors(sushi);

sushi = new SauceSucreeDecorator(sushi);
printIceCreamFlavors(sushi);

sushi = new SauceSaleeDecorator(sushi);
printIceCreamFlavors(sushi);

sushi = new GingembreDecorator(sushi);
printIceCreamFlavors(sushi);

sushi = new WasabiDecorator(sushi);
printIceCreamFlavors(sushi);

