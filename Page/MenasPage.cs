using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class MenasPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public MenasPage(IWebDriver webdriver) : base(webdriver)
        { }

        public IWebElement Menas => Driver.FindElement(By.CssSelector(".basicMenuTemplate > ul:nth-child(1) > li:nth-child(2) > a:nth-child(1)"));
        public IWebElement AJ4Cactus => Driver.FindElement(By.CssSelector("a.pr_productItem:nth-child(35) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        public IWebElement AJ4CactusDydis => Driver.FindElement(By.CssSelector("div.customCheckbox:nth-child(3) > label:nth-child(1) > span:nth-child(2)"));
        public IWebElement AJ4CactusIKrepseli => Driver.FindElement(By.CssSelector(".core_addToCart"));

        public MenasPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
    }
}
