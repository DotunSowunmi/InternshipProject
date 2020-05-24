using BlueOceanIntershipProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueOceanIntershipProject.PageObjects
{
    class GiftreteDashboardPage
    {
        IWebDriver driver;

        IWebElement giftreteLogo => driver.FindElement(By.XPath("//div[@class='col-lg-1 col-md-3 col-4 text-lg-left']//img"));
        IWebElement profileName => driver.FindElement(By.XPath("//span[@class='font-size-15 color--light-3']"));
        IWebElement logoutLink => driver.FindElement(By.XPath("//ul[@class='user-info-menu']//a[contains(text(),'Logout')]"));
        IWebElement blogLink => driver.FindElement(By.XPath("//span[contains(text(),'Blog')]"));
        IWebElement communityLink => driver.FindElement(By.XPath("//span[contains(text(),'Community')]"));
        IWebElement searchButton => driver.FindElement(By.XPath("//i[@class='font-size-12 color--light-1 dl-icon-search1']"));
        IWebElement helpSupport => driver.FindElement(By.XPath("//ul[@class='user-info-menu']//a[contains(text(),'Help & Support')]"));
        IWebElement logOutSuccessfullyElement => driver.FindElement(By.XPath("//*[@href='#nav-signin']"));
        IWebElement blogHomeElement => driver.FindElement(By.XPath("//li[@id='menu-item-289']//span[@class='menu-text'][contains(text(),'Welcome')]"));
        IWebElement communityHomePageElement => driver.FindElement(By.XPath("//a[contains(text(),'Read Faqs on Community')]"));
        IWebElement searchHomePageElement => driver.FindElement(By.XPath("//h2[contains(@class,'heading-secondary font-weight-600 text-left font-size-20')]"));
        IWebElement helpPageHomeElement => driver.FindElement(By.XPath("//h2[contains(text(),'Get in touch with us')]"));
        IWebElement accountDtlTab => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/ul/a[2]"));
        IWebElement profilePictureIcon => driver.FindElement(By.XPath("//input[@id='profileBtnlnk']"));
        IWebElement chooseFileLink => driver.FindElement(By.XPath("//input[@id='image_upload_profile']"));
        IWebElement uploadProfileImage => driver.FindElement(By.XPath("//a[@id='btn_upload_profile']"));
        public void ClickOnUploadProfileImage()
        {
            uploadProfileImage.Click();
        }
        public void ClickChooseFileLink()
        {
            chooseFileLink.SendKeys("C:\\Users\\dotun\\source\\repos\\BlueOceanIntershipProject\\TestData\\Test\\images (1).jpg");
        }

        public void ClickProfilePictureIcon()
        {
            profilePictureIcon.Click();
        }
        public void ClickOnAccountDtlTab()
        {

            accountDtlTab.Click();
        }
        public void ClickProfileName()
        {
            profileName.Click();
        }
        public bool IsHelpPageHomeElementDisplayed()
        {
            Thread.Sleep(5000);
            return helpPageHomeElement.Displayed;
        }
        public bool IsSearchHomePageElementDisplayed()
        {
            Thread.Sleep(5000);
            return searchHomePageElement.Displayed; 
        }
        public bool IsCommunityHomePageElementDisplayed()
        {
            Thread.Sleep(5000);
            return blogHomeElement.Displayed;
        }
        public bool IsBlogHomeElementDisplayed()
        {
            Thread.Sleep(5000);
            return communityHomePageElement.Displayed;
        }
        public void ClickBlogLink()
        {
            blogLink.Click();
        }
        public bool IsLogOutSuccessfullyElementDisplayed()
        {
            Thread.Sleep(5000);
            return logOutSuccessfullyElement.Displayed;
        }
        public void ClickHelpSupport()
        {
            helpSupport.Click();
        }
        public void ClickSearchButton()
        {
            searchButton.Click();
        }
        public void ClickCommunityLink()
        {
            communityLink.Click();
        }
        public void ClickLogoutLink()
        {
            logoutLink.Click();
        }
        public void ClickGiftreteLogo()
        {
            giftreteLogo.Click();
        }
        public GiftreteDashboardPage()
        {
            driver = Hook.driver;
        }
    }
}
