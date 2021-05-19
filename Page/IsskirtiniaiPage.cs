using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class IsskirtiniaiPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public IsskirtiniaiPage(IWebDriver webdriver) : base(webdriver)
        { }

        public IWebElement Kedai => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)"));
        public IWebElement IsskirtiniaiKedai => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(3) > a:nth-child(1)"));
        public IWebElement IsskirtinisKedas => Driver.FindElement(By.CssSelector("a.pr_productItem:nth-child(6) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        public IWebElement IsskirtKedasDydis => Driver.FindElement(By.CssSelector("div.customCheckbox:nth-child(2) > label:nth-child(1) > span:nth-child(2)"));
        public IWebElement IsskirtIKrepseli => Driver.FindElement(By.CssSelector(".core_addToCart"));

        public IsskirtiniaiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
}
