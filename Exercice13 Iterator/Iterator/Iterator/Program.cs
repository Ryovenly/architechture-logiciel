// See https://aka.ms/new-console-template for more information
using Iterator;
using System.Reflection;

Console.WriteLine("Hello, World!");


List<Game> games = new List<Game>
{
    new Game("Tales of Arise", "PS4"),
    new Game("FIFA22", "PS5"),
    new Game("God of War", "PS5")
};

GameStoreIterator GameIterator = new GameStoreIterator(games);

for(int i = 0; i < games.Count - 1; i++)
{
    var t = GameIterator.Next();
    Game game = (Game)t;
    Console.WriteLine("name: " + game.name + " console: " + game.console);
}

