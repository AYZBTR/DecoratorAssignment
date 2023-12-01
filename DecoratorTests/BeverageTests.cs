using DecoratorAssignment; // Assuming the namespace of the original code
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests
{
    [TestClass]
    public class BeverageTests
    {
        // Instructions:
        // To enable the tests, just remove the /* part above each test
        // You should use these tests to see that your solution works
        // and utilizes the decorator pattern correctly
        // NOTE! Don't modify the test themselves
   
        [TestMethod]
        public void EspressoTest()
        {
            IBeverage beverage = new Expresso();
            Assert.AreEqual("Espresso", beverage.GetDescription());
            Assert.AreEqual(2.90M, beverage.GetCost());
        }
    
        [TestMethod]
        public void HouseBlendTest()
        {
            IBeverage beverage = new HouseBlend();
            Assert.AreEqual("House Blend Coffee", beverage.GetDescription());
            Assert.AreEqual(1.80M, beverage.GetCost());
        }
      
        [TestMethod]
        public void DarkRoastWithCondimentsTest()
        {
            IBeverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new WhippedCream(beverage);
            Assert.AreEqual("Dark Roast Coffee, Mocha, Mocha, Whip", beverage.GetDescription());
            Assert.AreEqual(1.49M, beverage.GetCost());
        }
      
        [TestMethod]
        public void HouseBlendWithCondimentsTest()
        {
            IBeverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new WhippedCream(beverage);
            Assert.AreEqual("House Blend Coffee, Soy, Mocha, Whip", beverage.GetDescription());
            Assert.AreEqual(1.34M, beverage.GetCost());
        }
     
        [TestMethod]
        public void DecafWithCondimentsTest()
        {
            IBeverage beverage = new Decaf();
            beverage = new Mocha(beverage);
            beverage = new WhippedCream(beverage);
            Assert.AreEqual("Decaf Coffee, Mocha, Whip", beverage.GetDescription());
            Assert.AreEqual(1.35M, beverage.GetCost());
        }
    }
}
