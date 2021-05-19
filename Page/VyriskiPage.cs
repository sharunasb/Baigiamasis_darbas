using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class VyriskiPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";
        
        public VyriskiPage(IWebDriver webdriver) : base(webdriver)
        {}

        public IWebElement Kedai => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)"));
        public IWebElement VyrKedas => Driver.FindElement(By.CssSelector("a.pr_productItem:nth-child(23) > div:nth-child(1) > div:nth-child(1) > img:nth-child(1)"));
        public IWebElement VyrDydis => Driver.FindElement(By.CssSelector("div.customCheckbox:nth-child(8) > label:nth-child(1) > span:nth-child(2)"));
        public IWebElement VyrKedasIKrepseli => Driver.FindElement(By.CssSelector(".core_addToCart"));

        public VyriskiPage AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent"
                , "q7vrc1pi1q6d2nqii6kjlhgqgu"
                , "www.kixart.lt"
                , "/"
                , DateTime.Now.AddDays(3));

            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();

            return this;
        }

        public VyriskiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
    
}
