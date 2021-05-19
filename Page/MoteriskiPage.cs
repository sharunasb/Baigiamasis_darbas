using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class MoteriskiPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public MoteriskiPage(IWebDriver webdriver) : base(webdriver)
        { }
        
        
        public IWebElement Kedai => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)"));
        public IWebElement Moteriski => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div[1]/div[2]/div/div/div[2]/span/div[2]/label/span"));
        public IWebElement MotKedas => Driver.FindElement(By.CssSelector("a.pr_productItem:nth-child(7) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        public IWebElement MotDydis => Driver.FindElement(By.CssSelector("div.customCheckbox:nth-child(3) > label:nth-child(1) > span:nth-child(2)"));
        public IWebElement MotKedasIKrepseli => Driver.FindElement(By.CssSelector(".core_addToCart"));

        public MoteriskiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
}
