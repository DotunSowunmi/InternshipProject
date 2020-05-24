﻿using BlueOceanIntershipProject.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueOceanIntershipProject.StepDefinitions
{
    [Binding]
    public class GiftreteDashboardSteps
    {
        GiftreteDashboardPage giftreteDashboardPage;
        public GiftreteDashboardSteps()
        {
            giftreteDashboardPage = new GiftreteDashboardPage();
        }


        [Given(@"I click Giftrete logo")]
        public void GivenIClickGiftreteLogo()
        {
            giftreteDashboardPage.ClickGiftreteLogo();
        }


        [Given(@"I click my profile name")]
        public void GivenIAmOnMyUserHomePage()
        {
            giftreteDashboardPage.ClickProfileName();
        }


        [Given(@"I click Logout link")]
        public void GivenIClickLogoutLink()
        {
            giftreteDashboardPage.ClickLogoutLink();
        }
        
        [Given(@"I click Blog link")]
        public void GivenIClickBlogLink()
        {
            giftreteDashboardPage.ClickBlogLink();
        }
        
        [Given(@"I click Community link")]
        public void GivenIClickCommunityLink()
        {
            giftreteDashboardPage.ClickCommunityLink();
        }
        
        [Given(@"I click on Search button")]
        public void GivenIClickOnSearchButton()
        {
            giftreteDashboardPage.ClickSearchButton();
        }
        
        [Given(@"I click Help & Support")]
        public void GivenIClickHelpSupport()
        {
            giftreteDashboardPage.ClickHelpSupport();
        }
        
        [Then(@"I should be able to log out of my home page")]
        public void ThenIShouldBeAbleToLogOutOfMyHomePage()
        {
            Assert.True(giftreteDashboardPage.IsLogOutSuccessfullyElementDisplayed());
        }
        
        [Then(@"I should be able to view Blog page")]
        public void ThenIShouldBeAbleToViewBlogPage()
        {
            Assert.True(giftreteDashboardPage.IsBlogHomeElementDisplayed());
        }
        
        [Then(@"I should be able to view Community category page")]
        public void ThenIShouldBeAbleToViewCommunityCategoryPage()
        {
            Assert.True(giftreteDashboardPage.IsCommunityHomePageElementDisplayed());        
        }
        
        [Then(@"I should be able to view the search page")]
        public void ThenIShouldBeAbleToViewTheSearchPage()
        {
            Assert.True(giftreteDashboardPage.IsSearchHomePageElementDisplayed());
        }
        
        [Then(@"I should be able to view help page")]
        public void ThenIShouldBeAbleToViewHelpPage()
        {
            Assert.True(giftreteDashboardPage.IsHelpPageHomeElementDisplayed());
        }
    }
}