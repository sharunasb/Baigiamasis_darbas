using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Page
{
    public class KixArtPage : BasePage
    {
        private const string PageAddress = "https://www.kixart.lt/";

        public KixArtPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public KixArtPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }



        public KixArtPage AcceptCookies()
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

        public static void VyrKedaiIKrepseli()
        { }
        public static void MotKedaiIKrepseli()
        { }
        public static void SpecKedaiIKrepseli()
        { }
        public static void MenasIKrepseli()
        { }
        public static void CleanMyBasket()
        { }
        public static void Aksesuaru()
        { }
    }
}
