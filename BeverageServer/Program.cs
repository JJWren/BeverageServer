using BeverageServer.Classes.Drinks;
using BeverageServer.Classes.Extensions;
using BeverageServer.Classes.Factories;

List<Drink> requestedBeverages = BeverageTrayFactory.CreateDefaultBeverageTray();
List<Drink> favoriteBeverages = BeverageTrayFactory.CreateFavoriteBeverageTray();

Console.WriteLine($"{"REQUESTED DRINKS".ToBannerString()}\n");
foreach (Drink beverage in requestedBeverages)
{
    Console.WriteLine($"{beverage.ShowDrinkInformation()}\n");
}

Console.WriteLine($"\n{"FAVORITE DRINKS".ToBannerString()}\n");
foreach (Drink beverage in favoriteBeverages)
{
    Console.WriteLine($"{beverage.ShowDrinkInformation()}\n");
}

Environment.Exit(0);
