using DiscountCalculator;

namespace MSTests
{
    [TestClass]
    public class MSTests
    {
        private const int DEFAULT_AGE = 30;

        [TestMethod]
        public void Returns015PctForBasicCustomer()
        {
            var customer = CreateCustomer();
            var result = new CalculateDiscount().CalculatePercentDiscount(customer);
            Assert.AreEqual(result, .15m);
        }

        private Customer CreateCustomer(int age = DEFAULT_AGE, DateTime? dateOfPurchase = null)
        {
            return new Customer();
        }
    }
}