using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestProject1
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
            //Browser drivers
            IWebDriver webDriver = new ChromeDriver();

            //Navigate to site

            webDriver.Navigate().GoToUrl("https://ledtechnics.dp.ua/ua/?utm_source=email2customer_look_companyname&utm_medium=Email&utm_campaign=after_order_cancel");

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}