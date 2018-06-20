using AutomationTools.PageObjects;
using AutomationTools.Selectors;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCopyDelivery.UI.Tests.Pages
{
    //[Frames(MainFrame = "#frmain")]
    public class LandingPage : HardCopyDeliveryBasePage<LandingPage>, IPage
    {
        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        [IsLoaded(Visibility = true)]
        [FindSelectorBy(Locator = "API Documentation", ByType = ByType.LinkText)]
        protected Selector apiDocs_Link;

        [FindSelectorBy(Locator = "Help Desk", ByType = ByType.LinkText)]
        protected Selector helpDesk_Link;
        
        [FindSelectorBy(ByType = ByType.Xpath, Locator = "//a[contains(@href, '/hardcopydelivery/Account/Login')]")]
        protected Selector login_Button;

        public void Click_APIDocsLink()
        {
            apiDocs_Link.Click();
        }

        public void Click_HelpDeskLink()
        {
            helpDesk_Link.Click();
        }

        public void Click_LoginButton()
        {
            login_Button.Click();
        }
    }
}
