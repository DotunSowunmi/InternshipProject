Feature: Login
	As a registered user of giftrete website
	I should be able to log in so as to use giftrete


@mytag
Scenario: Login with valid detail
	Given I navigate to Giftrete website
	When I click on sign in
	And I enter my email
	And I enter my valid password
	And I click on sign in button
	Then the user homepage should be displayed
	



	Scenario: Login with Invalid detail
	   Given I navigate to Giftrete website
	    When I click on sign in
	     And I enter my email
	     And I enter my Invalid password
		 And I click on sign in button
	    Then the message "Your login credentials are invalid. Please try again" should be displayed 
