using BeverageServer.Classes.Extensions;

namespace BeverageServer.Classes.Drinks
{
    public class Soda : Drink
    {
        public override string Name { get; set; } = "Pepsi";
        public override bool IsCarbonated { get; set; } = true;
        public override string Description { get; set; } = "A carbonated, sweetened soft drink.";

        public override string ShowDrinkInformation()
        {
            return $"Beverage Type: {GetDrinkType()}\nName: {Name}\nCarbonated: {BasicMethods.ReturnYesOrNoForBools(IsCarbonated)}\nDescription: {Description}";
        }
    }
}
