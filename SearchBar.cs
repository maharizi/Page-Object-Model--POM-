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

        public void LoadApplication(string url, IWebDriver driver)
        {
            driver.Url = url;
        }

        public void SetTextSearch(string text, IWebDriver driver)
        {
            var set = driver.FindElement(By.Id("gh-ac"));
            set.SendKeys(text);
        }

        public void ClickSearch(IWebDriver driver)
        {
            var click = driver.FindElement(By.Id("gh-btn"));
            click.Click();
        }
    }
}
