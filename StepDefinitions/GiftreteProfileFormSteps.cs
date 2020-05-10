using BlueOceanIntershipProject.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueOceanIntershipProject.StepDefinitions
{
    [Binding]
    public class GiftreteProfileFormSteps
    {
        GiftreteProfileFormPage giftreteProfileFormPage;
        
        public GiftreteProfileFormSteps()
        {
            giftreteProfileFormPage = new GiftreteProfileFormPage();
        }
        
        [When(@"I enter valid email address")]
        public void WhenIEnterValidEmailAddress()
        {
            giftreteProfileFormPage.EnterValidEmailAddress();
        }
        
        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            giftreteProfileFormPage.EnterValidPassword();
        }
        
        [When(@"I click on account detail tab")]
        public void WhenIClickOnAccountDetailTab()
        {
            giftreteProfileFormPage.ClickOnAccountDetailTab();
        }
        
        [When(@"I click on the edit details")]
        public void WhenIClickOnTheEditDetails()
        {
            giftreteProfileFormPage.ClickOnEditDetail();
        }
        
        [When(@"I click title drop down")]
        public void WhenIClickTitleDropDown()
        {
            giftreteProfileFormPage.ClickOnTitleDropDown();
        }
        
        [When(@"I select title from dropdown box")]
        public void WhenISelectTitleFromDropdownBox()
        {
            giftreteProfileFormPage.SelectTitleFromDropDownBox();
        }
        
        [When(@"I edit First Name")]
        public void WhenIEditFirstName()
        {
            giftreteProfileFormPage.EditFirstName();
        }
        
        [When(@"I edit Last Name")]
        public void WhenIEditLastName()
        {
            giftreteProfileFormPage.EditLastName();
        }


        [When(@"I edit date of birth")]
        public void WhenIEditDateOfBirth()
        {
            giftreteProfileFormPage.EditDateOfBirth();
        }

        [When(@"I edit email address")]
        public void WhenIEditEmailAddress()
        {
            giftreteProfileFormPage.EditEmailAddress();
        }
        
        [When(@"i click on Phone country code icon")]
        public void WhenIClickOnPhoneCountryCodeIcon()
        {
            giftreteProfileFormPage.ClickOnPhoneCountryCode();
        }
        
        [When(@"I select new country code")]
        public void WhenISelectNewCountryCode()
        {
            giftreteProfileFormPage.SelectNewCountryCode();
        }
        
        [When(@"I edit Phone number")]
        public void WhenIEditPhoneNumber()
        {
            giftreteProfileFormPage.EditPhoneNumber();
        }
        
        [When(@"I edit about text box")]
        public void WhenIEditAboutTextBox()
        {
            giftreteProfileFormPage.EditAboutTextBox();
        }
        
        [When(@"I click to select Yes or No for community activity emails")]
        public void WhenIClickToSelectYesOrNoForCommunityActivityEmails()
        {
            giftreteProfileFormPage.ClickOnYesorNo();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            giftreteProfileFormPage.ClickOnSubmitButton();
            Thread.Sleep(500);
        }
        
        //[Then(@"my personal information should be edited successfully")]
        //public void ThenMyPersonalInformationShouldBeEditedSuccessfully()
        //{
           
        //}
        
        [Then(@"success notification box should be displayed")]
        public void ThenSuccessNotificationBoxShouldBeDisplayed()
        {
            Thread.Sleep(500);
            Assert.True(giftreteProfileFormPage.IssuccessfulNotificationMessageDispalyed());
        }
    }
}
