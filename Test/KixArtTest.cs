using baigiamasis_darbas.Page;
using baigiamasis_darbas.Tools;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Test
{
    public class KixArtTest : BaseTest
    {
        [Order(1)]
        [Test]
        public static void VyrKedaiIKrepseli()
        {

            VyriskiPage page = new VyriskiPage(driver);
            page.NavigateToDefaultPage();
            page.Kedai.Click();
            page.VyrKedas.Click();
            page.VyrDydis.Click();
            page.VyrKedasIKrepseli.Click();
        }
        [Order(2)]
        [Test]
        public static void MotKedaiIKrepseli()
        {
            MoteriskiPage page = new MoteriskiPage(driver);
            page.NavigateToDefaultPage();
            page.Kedai.Click();
            page.Moteriski.Click();
            page.MotKedas.Click();
            page.MotDydis.Click();
            page.MotKedasIKrepseli.Click();
        }
        [Order(3)]
        [Test]
        public static void SpecKedaiIKrepseli()
        {
            IsskirtiniaiPage page = new IsskirtiniaiPage(driver);
            page.NavigateToDefaultPage();
            page.Kedai.Click();
            page.IsskirtiniaiKedai.Click();
            page.IsskirtinisKedas.Click();
            page.IsskirtKedasDydis.Click();
            page.IsskirtIKrepseli.Click();
        }
        [Order(4)]
        [Test]
        public static void MenasIKrepseli()
        {
            MenasPage page = new MenasPage(driver);
            page.NavigateToDefaultPage();
            page.Menas.Click();
            page.AJ4Cactus.Click();
            page.AJ4CactusDydis.Click();
            page.AJ4CactusIKrepseli.Click();
        }
        [Order(5)]
        [Test]
        public static void CleanMyBasket()
        {
            MyBasketPage page = new MyBasketPage(driver);
            page.NavigateToDefaultPage();
            page.MyBasket.Click();
            page.CleanBasket.Click();
            page.CleanBasket.Click();
            page.CleanBasket.Click();
            
        }
        [Order(6)]
        [Test]
        public static void Aksesuaru()
        {
            AksesuaraiPage page = new AksesuaraiPage(driver);
            page.NavigateToDefaultPage();
            page.Aksesuarai.Click();
            page.Aksesuaras.Click();
            page.PliusDu.Click();
            page.AksesuarasIKrepseli.Click();
            page.CleanBasket.Click();
        }
    }
}
