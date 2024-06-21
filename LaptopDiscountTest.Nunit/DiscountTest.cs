using LaptopDiscount;

namespace LaptopDiscountTest.Nunit
{
    public class Tests
    {
        private EmployeeDiscount discount { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            discount = new EmployeeDiscount();
        }

        [Test]
        public void PartTimeTest_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.PartTime;
            discount.Price = 100;
            decimal value=discount.CalculateDiscountedPrice();
            Assert.That(value,Is.EqualTo(100));
            
        }

        [Test]
        public void PartialLoadTest_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.PartialLoad;
            discount.Price = 300;
            decimal value = discount.CalculateDiscountedPrice();
            Assert.That(value, Is.EqualTo(285));
            
        }

        [Test]
        public void FullTimeLoadTest_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.FullTime;
            discount.Price = 300;
            decimal value = discount.CalculateDiscountedPrice();
            Assert.That(value, Is.EqualTo(270));

        }


        [Test]
        public void FullTimeLoad_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.FullTime;
            discount.Price = 1000;
            decimal value = discount.CalculateDiscountedPrice();
            Assert.That(value, Is.EqualTo(900));

        }

        [Test]
        public void CompanyPurchasingTest_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.CompanyPurchasing;
            discount.Price = 300;
            decimal value = discount.CalculateDiscountedPrice();
            Assert.That(value, Is.EqualTo(240));

        }

        [Test]
        public void CompanyPurchasing_CalculateDiscountedPrice()
        {
            discount.EmployeeType = EmployeeType.CompanyPurchasing;
            discount.Price = 500;
            decimal value = discount.CalculateDiscountedPrice();
            Assert.That(value, Is.EqualTo(400));

        }
    }
}