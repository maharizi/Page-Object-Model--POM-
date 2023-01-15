using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class SearchBar
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = new ChromeDriver("C:\\bootcamp ness\\drivers");
        }

        public void LoadApplication(string url)
        {
            this.driver.Url = url;
        }

        public void SetTextSearch(string text)
        {
            var set = driver.FindElement(By.Id("gh-ac"));
            set.SendKeys(text);
        }

        public void ClickSearch()
        {
            var click = driver.FindElement(By.Id("gh-btn"));
            click.Click();
        }

        public void SetTextPrice(string price)
        {
            var set = driver.FindElement(By.Id("s0-52-12-0-1-2-6-0-8[3]-0-textrange-beginParamValue-textbox"));
            set.SendKeys(price);
        }

        public void ClickPrice()
        {
            var click = driver.FindElement(By.XPath("//*[@id=\"s0-52-12-0-1-2-6-0-8[3]-0-textrange\"]/div/div[3]/button"));
            click.Click();
        }
    }
}
