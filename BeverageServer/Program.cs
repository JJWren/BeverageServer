using BeverageServer.Classes;
using BeverageServer.Classes.Factories;

List<Drink> requestedBeverages = BeverageTrayFactory.CreateDefaultBeverageTray();
List<Drink> favoriteBeverages = BeverageTrayFactory.CreateFavoriteBeverageTray();

Console.WriteLine("####################\nREQUESTED DRINKS\n####################");
foreach (Drink beverage in requestedBeverages)
{
    Console.WriteLine($"{beverage.ShowDrinkInformation()}\n");
}

Console.WriteLine("####################\nFAVORITE DRINKS\n####################");
foreach (Drink beverage in favoriteBeverages)
{
    Console.WriteLine($"{beverage.ShowDrinkInformation()}\n");
}
