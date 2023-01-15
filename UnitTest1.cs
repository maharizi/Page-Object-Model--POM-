using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        Home home;

        [SetUp]
        public void Setup()
        {
            home = new Home();
        }

        [Test]
        public void Test1()
        {
            try
            {
                home.page.searchBar.InitBrowser();
                home.page.searchBar.LoadApplication("https://www.ebay.com/");
                home.page.searchBar.SetTextSearch("mouse");
                home.page.searchBar.ClickSearch();
                home.page.searchBar.SetTextPrice("50");
                home.page.searchBar.ClickPrice();

                Assert.Pass();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}