using bobsBagels.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagel()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");

        Assert.IsTrue(basket.bagels.Count() == 2);
    }
}