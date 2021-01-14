Feature: GoogleNewsHeadlines
	Openning Google news page and printing all the headlines.

@smoke
Scenario: Open Google news site
	Given I launch google news site
	And the news healdlines should be displayed 
	Then I print all the news headlines.
