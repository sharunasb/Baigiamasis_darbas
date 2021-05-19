using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class MyBasketPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public MyBasketPage(IWebDriver webdriver) : base(webdriver)
        { }

        public IWebElement MyBasket => Driver.FindElement(By.CssSelector(".fa-shopping-cart"));
        public IWebElement CleanBasket => Driver.FindElement(By.CssSelector(".fa-trash-alt"));

        public MyBasketPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
}
