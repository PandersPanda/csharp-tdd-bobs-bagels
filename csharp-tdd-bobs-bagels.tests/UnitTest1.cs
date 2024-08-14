using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("everythingbagel", 40)]
    [TestCase("fork", 4)]
    [TestCase("bucket", 135)]
    public void AddItemBasket(string product, int value)
    {
        Basket basket = new Basket();

        bool result = basket.Add(product, value);

        Assert.That(result, Is.True);
    }

    [Test]
    public void AddItemFullBasket()
    {
        Basket basket = new Basket();

        for (int i = 0; i < basket.capacity; i++)
        {
            basket.Add("product"+i, 0);
        }

        string product = "apple";
        int value = 10;

        bool result = basket.Add(product, value);

        Assert.That(result, Is.False);
    }

    [Test]
    public void RemoveExistingItem()
    {
        Basket basket = new Basket();
        string product = "salmon";
        int value = 90;
        basket.Add(product, value);

        bool result = basket.Remove(product);

        Assert.That(result, Is.True);
    }
    [Test]
    public void RemoveNonExistingItem()
    {
        Basket basket = new Basket();
        string product = "bag";

        bool result = basket.Remove(product);

        Assert.That(result, Is.False);
    }
    [Test]
    public void ChangeCapacity()
    {
        Basket basket = new Basket();
        int newCapacity = 6;

        int result = basket.ChangeCapacity(6);

        Assert.That(result, Is.EqualTo(newCapacity));
    }
}