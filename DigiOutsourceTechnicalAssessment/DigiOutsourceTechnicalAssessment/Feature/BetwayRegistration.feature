Feature: BetwayRegistration
	Betway Registration

@smoke
Scenario: Register on betway site
	Given I launch betway site
	And click on signup button
	And fill in the following details
	| Mobile number | Password | First Name | Surname |Email address            |    
	| 0618894807    | 2143     | Rabelani   | Denga   | rabelanedenga@gmail.com |
	And click Next Button
	And complete the registration form 
	| ID number     | Date of birth | Salary | Language |
	| 9208081213088 | 08/08/1992    | 20000  | English  |
	Then all the fields should be filled



           