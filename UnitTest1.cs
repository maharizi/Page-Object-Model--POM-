using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        public IWebDriver driver;
        Home home;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\bootcamp ness\\drivers");
            home = new Home();
        }

        [Test]
        public void Test1()
        {
            try
            {
                home.page.searchBar.LoadApplication("https://www.ebay.com/", driver);
                home.page.searchBar.SetTextSearch("mouse", driver);
                home.page.searchBar.ClickSearch(driver);
                home.page.filterBar.SetTextPrice("50", driver);
                home.page.filterBar.ClickPrice(driver);

                Assert.Pass();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}