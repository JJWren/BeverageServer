using BeverageServer.Classes.Extensions;

namespace BeverageServer.Classes.Drinks
{
    public class Juice : Drink
    {
        public override string Name { get; set; } = "Orange Juice";
        public override bool IsCarbonated { get; set; } = false;
        public override string Description { get; set; } = "Tangy, sweet orange juice.";
        public string BaseFruitIngredient { get; set; } = "Orange";
        public List<string> SecondaryFruitIngredients { get; set; } = new List<string>();

        public string StringifySecondaryIngredients()
        {
            return string.Join(", ", SecondaryFruitIngredients);
        }
        public override string ShowDrinkInformation()
        {
            return $"Beverage Type: {GetDrinkType()}\nName: {Name}\nCarbonated: {BasicMethods.ReturnYesOrNoForBools(IsCarbonated)}\nBase Fruit: {BaseFruitIngredient}\nOther Fruit: {StringifySecondaryIngredients()}\nDescription: {Description}";
        }
    }
}
