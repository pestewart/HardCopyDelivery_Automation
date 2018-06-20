using AutomationTools.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCopyDelivery.UI.Tests.Pages
{
    public class HardCopyDeliveryBasePage<T> : PageObject<T> where T : PageObject<T>, IPage
    {
        public HardCopyDeliveryBasePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
