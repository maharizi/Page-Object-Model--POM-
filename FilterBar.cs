using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class FilterBar
    {

        public void SetTextPrice(string price, IWebDriver driver)
        {
            var set = driver.FindElement(By.Id("s0-52-12-0-1-2-6-0-8[3]-0-textrange-beginParamValue-textbox"));
            set.SendKeys(price);
        }

        public void ClickPrice(IWebDriver driver)
        {
            var click = driver.FindElement(By.XPath("//*[@id=\"s0-52-12-0-1-2-6-0-8[3]-0-textrange\"]/div/div[3]/button"));
            click.Click();
        }
    }
}
