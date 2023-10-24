namespace BeverageServer.Classes.Factories
{
    /// <summary>
    /// Factory design to instantiatie different beverage trays.
    /// </summary>
    public class BeverageTrayFactory
    {
        public static List<Drink> CreateDefaultBeverageTray()
        {
            return new List<Drink>()
            {
                new Beer(),
                new Soda(),
                new Juice(),
            };
        }

        public static List<Drink> CreateFavoriteBeverageTray()
        {
            return new List<Drink>()
            {
                new Beer()
                {
                    Name = "Yuengling",
                    Description = "An iconic American lager famous for its rich amber color and medium-bodied flavor.",
                    AlcoholContent = 4.5m,
                },
                new Soda()
                {
                    Name = "Grape Fanta",
                    Description = "A sweetened and carbonated grape drink.",
                },
                new Juice()
                {
                    Name = "Fruit Melody",
                    Description = "A fruit blend with a tropical flavor!",
                    BaseFruitIngredient = "Pineapple",
                    SecondaryFruitIngredients = new List<string>()
                    {
                        "Cherry",
                        "Cranberry",
                        "Lime",
                        "Orange",
                    }
                },
            };
        }
    }
}
