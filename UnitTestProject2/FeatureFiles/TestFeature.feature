Feature: Login to the naukri portal

A short summary of the feature

@tag1
Scenario: Login Scenario of Naukri
	Given User is at Login Page
	When User click on Login button
	Then Login window should appear
	When I provide username and password
	And Click on Login button
	Then User should redirect to Home page

	Scenario: Search using keyword
	Given User is at Home page 
	When User enter some value inside search box
	And Click on Search button
	Then Search result should appear

