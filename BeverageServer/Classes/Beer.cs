using BeverageServer.Extensions;

namespace BeverageServer.Classes
{
    public class Beer : Drink
    {
        public override string Name { get; set; } = "Budweiser";
        public override bool IsCarbonated { get; set; } = true;
        public override string Description { get; set; } = "A medium-bodied, flavorful, crisp American-style lager.";
        public decimal AlcoholContent { get; set; } = 5.0m;

        public override string ShowDrinkInformation()
        {
            return $"Beverage Type: {GetDrinkType()}\nName: {Name}\nCarbonated: {BasicMethods.ReturnYesOrNoForBools(IsCarbonated)}\nAlcohol Content: {AlcoholContent}%\nDescription: {Description}";
        }
    }
}
