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

   Scenario: Changing Giftrete profile picture
	Given I click on account detail tab
    And I click on change of profile picture icon
    And I click on choose file link
    And I click on upload file image button
   #Then I should be able to upload my picture successfully

    Scenario: Changing Giftrete banner picture
	Given I click on account detail tab
    And I click on change of banner picture icon
    And I click on choose banner file link
    And I click on upload banner image button
   #Then I should be able to upload my picture successfully



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
    