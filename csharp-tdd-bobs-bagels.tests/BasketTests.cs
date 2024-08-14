using bobsBagels.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelAmount()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");

        Assert.IsTrue(basket.Bagels.Count() == 2);
    }

    [Test]
    public void AddBagelContains()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");

        Assert.IsTrue(basket.Bagels.Contains("Cream cheese"));
    }

    [Test]
    public void RemoveBagel()
    {
        Basket basket = new Basket();
        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");

        basket.RemoveBagel("Salmon");

        Assert.IsTrue(basket.Bagels.Count() == 1);
    }

    [Test]
    public void GetBasketSize()
    {
        Basket basket = new Basket();

        Assert.IsTrue(basket.BasketSize == 5);
    }
}