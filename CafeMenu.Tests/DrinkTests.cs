namespace CafeMenu.Tests;

[TestClass]
public class DrinkTests
{
    [TestMethod]
    public void Constructor_KeepsTheNameBasePriceAndSize()
    {
        Drink drink = new Drink("Latte", 4.00m, "Medium");

        Assert.AreEqual("Latte", drink.Name);
        Assert.AreEqual(4.00m, drink.BasePrice);
        Assert.AreEqual("Medium", drink.Size);
    }

    [TestMethod]
    public void Price_ForASmallDrink_IsTheBasePrice()
    {
        Drink drink = new Drink("Latte", 4.00m, "Small");

        Assert.AreEqual(4.00m, drink.Price);
    }

    [TestMethod]
    public void Price_ForAMediumDrink_IsFiftyCentsMore()
    {
        Drink drink = new Drink("Latte", 4.00m, "Medium");

        Assert.AreEqual(4.50m, drink.Price);
    }

    [TestMethod]
    public void Price_ForALargeDrink_IsOneDollarMore()
    {
        Drink drink = new Drink("Latte", 4.00m, "Large");

        Assert.AreEqual(5.00m, drink.Price);
    }

    [TestMethod]
    public void PriceFor_TwoLargeDrinks_UsesTheLargePrice()
    {
        Drink drink = new Drink("Hot Chocolate", 3.25m, "Large");

        decimal price = drink.PriceFor(2);

        Assert.AreEqual(8.50m, price, "PriceFor is inherited, and uses the drink's own Price.");
    }

    [TestMethod]
    public void ToString_PutsTheSizeFirst()
    {
        Drink drink = new Drink("Latte", 4.00m, "Large");

        Assert.AreEqual("Large Latte, $5.00", drink.ToString());
    }

    [TestMethod]
    public void Price_OfADrinkHeldAsAMenuItem_StillDependsOnTheSize()
    {
        MenuItem item = new Drink("Latte", 4.00m, "Large");

        Assert.AreEqual(5.00m, item.Price, "Override Price, so a drink is priced by its size wherever it's used.");
    }
}
