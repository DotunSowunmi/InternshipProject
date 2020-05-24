Feature: GiftreteDashboard
	In order to manage Giftrete 
	I want to be able to access my dasboard



Background: 
		Given I navigate to Giftrete website
	     When I click on sign in
	      And I enter my email
	      And I enter my valid password
	      And I click on sign in button

@mytag
Scenario: Managing GiftreteDashboard
	Given I click my profile name 
    And I click Logout link
   Then I should be able to log out of my home page


   Scenario: Read community blogPage
	 Given I click Blog link
      #Then I should be able to view Blog page

   Scenario: View community page
	  Given  I click Community link
      #Then I should be able to view Community category page


  Scenario: Dashboard search button 
   Given I click on Search button 
    Then I should be able to view the search page


   Scenario: Dashboard help page
    Given I click my profile name 
    And I click Help & Support 
   Then I should be able to view help page 
    