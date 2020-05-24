 using BlueOceanIntershipProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueOceanIntershipProject.PageObjects
{
    class GiftreteProfileFormPage
    {
        IWebDriver driver;
        public GiftreteProfileFormPage()
        {
            driver = Hook.driver;
        }

        IWebElement clickOnSignin => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement enterValidEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterValidPassword => driver.FindElement(By.Id("user_password"));
        IWebElement clickOnSigninButton => driver.FindElement(By.CssSelector("#btn_signin"));
        IWebElement clickOnAccountDetailTab => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/ul/a[2]"));
        IWebElement clickOnEditDetail => driver.FindElement(By.CssSelector("#lnk_edit_personal"));
        IWebElement clickOnTitleDropDown => driver.FindElement(By.XPath("//*[@id='name_prefix']"));
        IWebElement selectTitleFromDropDownBox => driver.FindElement(By.XPath("//*[@id='name_prefix']/option[3]"));
        IWebElement editFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement editLastName => driver.FindElement(By.XPath("//input[@id='last_name']"));
        IWebElement editDateOfBirth => driver.FindElement(By.XPath("//input[@id='dateofbirth']"));
        IWebElement editEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnPhoneCountryCode => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[6]/div/div/div/div[2]"));
        IWebElement selectNewCountryCode => driver.FindElement(By.CssSelector("#iti-item-gb > span.country-name"));
        IWebElement editPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement editAboutTextBox => driver.FindElement(By.XPath("//textarea[@id='about']"));
        IWebElement clickOnYesOrNo => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[8]/div[2]/label[2]"));
        IWebElement clickOnSubmitButton => driver.FindElement(By.Id("btn_save_details"));
        IWebElement successfulNotificationMessage => driver.FindElement(By.XPath("//p[@id='successMessage']"));


        //IWebElement fileInput => driver.FindElement(By.Name(""));

        //public void FileInput()
        //{
        //    fileInput.SendKeys("C:/path/to/file.jpg");
        //}

        //public bool IssuccessfulNotificationMessageDispalyed()
        //{
        //    return successfulNotificationMessage.Displayed;
        //}
        public string GetTextForsuccessfulNotificationMessage()
        {
            Thread.Sleep(500);
            return successfulNotificationMessage.Text;
        }
        public void ClickOnSubmitButton()
        {
            clickOnSubmitButton.Click();
        }
        public void ClickOnYesorNo()
        {
            clickOnYesOrNo.Click();
        }
        public void EditAboutTextBox()
        {
            editAboutTextBox.Clear();
            editAboutTextBox.SendKeys("Jesus is Lord");
        }


        public void EditPhoneNumber()
        {
            editPhoneNumber.Clear();
            editPhoneNumber.SendKeys("07934567890");
        }
        public void SelectNewCountryCode()
        {
            selectNewCountryCode.Click();
        } 
        public void ClickOnPhoneCountryCode()
        {
            clickOnPhoneCountryCode.Click();
        }
        public void EditEmailAddress()
        {
            editEmailAddress.Clear();
            editEmailAddress.SendKeys("yinkaland@gmail.com");
        }
        public void EditDateOfBirth()
        {
            editDateOfBirth.Clear();
            editDateOfBirth.SendKeys("24/06/1930");
        }
        public void EditLastName()
        {
            editLastName.Clear();
            editLastName.SendKeys("Sowunmi");
        }
        public void EditFirstName()
        {
            editFirstName.Clear();
            editFirstName.SendKeys("Yinka");
        }

        public void SelectTitleFromDropDownBox()
        {
            selectTitleFromDropDownBox.Click();
        }

        public void ClickOnTitleDropDown()
        {
            clickOnTitleDropDown.Click();
        }

        public void ClickOnEditDetail()
        {
            clickOnEditDetail.Click();
        }
        public void ClickOnAccountDetailTab()
        {
            
            clickOnAccountDetailTab.Click();
        }
        public void ClickonSigninButton()
        {
            clickOnSignin.Click();
            
        }

        public void EnterValidPassword()
        {
            enterValidPassword.SendKeys("yinka1969");
        }
        public void EnterValidEmailAddress()
        {
            enterValidEmailAddress.SendKeys("yinkaland000@gmail.com");
        }
        public void ClickOnSignin()
        {
            clickOnSignin.Click();
        }
        public void NavigateToGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("http://www.qa.giftrete.com/");
        }

        

    }
}
