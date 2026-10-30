namespace CafeMenu.Tests;

[TestClass]
public class PastryTests
{
    [TestMethod]
    public void Constructor_KeepsTheNameBasePriceAndWarmed()
    {
        Pastry pastry = new Pastry("Croissant", 3.00m, true);

        Assert.AreEqual("Croissant", pastry.Name);
        Assert.AreEqual(3.00m, pastry.BasePrice);
        Assert.IsTrue(pastry.IsWarmed);
    }

    [TestMethod]
    public void Price_ForAPastryNotWarmed_IsTheBasePrice()
    {
        Pastry pastry = new Pastry("Croissant", 3.00m, false);

        Assert.AreEqual(3.00m, pastry.Price);
    }

    [TestMethod]
    public void Price_ForAWarmedPastry_IsSeventyFiveCentsMore()
    {
        Pastry pastry = new Pastry("Croissant", 3.00m, true);

        Assert.AreEqual(3.75m, pastry.Price);
    }

    [TestMethod]
    public void ToString_ForAWarmedPastry_EndsWithWarmed()
    {
        Pastry pastry = new Pastry("Croissant", 3.00m, true);

        Assert.AreEqual("Croissant, $3.75 (warmed)", pastry.ToString());
    }

    [TestMethod]
    public void ToString_ForAPastryNotWarmed_IsTheNameAndPrice()
    {
        Pastry pastry = new Pastry("Cinnamon Roll", 3.50m, false);

        Assert.AreEqual("Cinnamon Roll, $3.50", pastry.ToString());
    }

    [TestMethod]
    public void Price_OfAPastryHeldAsAMenuItem_StillIncludesWarming()
    {
        MenuItem item = new Pastry("Croissant", 3.00m, true);

        Assert.AreEqual(3.75m, item.Price);
    }
}
