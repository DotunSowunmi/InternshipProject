using BlueOceanIntershipProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOceanIntershipProject.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterValidPassword => driver.FindElement(By.Id("user_password"));
        IWebElement clickOnSigninButton => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement userHomePageElement => driver.FindElement(By.CssSelector("body > div.wrapper > header.header.header-transparent.lnk-others.header-fullwidth.header-style-1.hide > div > div.container-fluid > div > div.col-xl-5.col-lg-4.col-md-9.col-8 > ul > li.d-flex.cursor.justify-content-between.align-items-center.plr--10.ptb--5.bg-f7.brd-rad2.user-info-menu-btn.brd-line3 > span"));
        IWebElement enterInvalidPassword => driver.FindElement(By.Id("user_password"));
        IWebElement errorMessageElement => driver.FindElement(By.XPath("//*[@id='dng_msg_t']"));

        public string GetTextErrorMessageElement()
        {
            return errorMessageElement.Text;
        }
        public void EnterInvalidPassword()
        {
            enterInvalidPassword.SendKeys("fimisola07");
        }
        public bool IsUserHomePageDisplayed()
        {
            return userHomePageElement.Displayed;
        }

        public void ClickOnSigninButton()
        {
            clickOnSigninButton.Click();
        }
        public void EnterValidPassword()
        {
            enterValidPassword.SendKeys("yinka1969");
        }
        public void EnterEmailAddress()
        {
            enterEmailAddress.SendKeys("yinkaland@gmail.com");
        }
        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

        public void NavigateToGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }

        public LoginPage()
        {
            driver = Hook.driver;
        }
    }
}
