using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class AksesuaraiPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public AksesuaraiPage(IWebDriver webdriver) : base(webdriver)
        { }

        public IWebElement Aksesuarai => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(4) > a:nth-child(1)"));
        public IWebElement Aksesuaras => Driver.FindElement(By.CssSelector("a.pr_productItem:nth-child(12) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        public IWebElement PliusDu => Driver.FindElement(By.CssSelector(".fa-plus"));
        public IWebElement AksesuarasIKrepseli => Driver.FindElement(By.CssSelector(".core_addToCart"));
        public IWebElement CleanBasket => Driver.FindElement(By.CssSelector(".fa-trash-alt"));

        public AksesuaraiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
}
