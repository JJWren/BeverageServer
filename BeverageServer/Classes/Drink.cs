using BeverageServer.Extensions;

namespace BeverageServer.Classes
{
    public class Drink
    {
        public virtual string Name { get; set; } = "Water";
        public virtual bool IsCarbonated { get; set; } = false;
        public virtual string Description { get; set; } = "It's just plain, refreshing water.";

        /// <summary>
        /// Returns the type of drink.
        /// </summary>
        /// <returns>drink type.</returns>
        public string GetDrinkType()
        {
            return GetType().Name;
        }

        public virtual string ShowDrinkInformation()
        {
            return $"Beverage Type: {GetDrinkType}\nName: {Name}\nCarbonated: {BasicMethods.ReturnYesOrNoForBools(IsCarbonated)}\nDescription: {Description}";
        }
    }
}
