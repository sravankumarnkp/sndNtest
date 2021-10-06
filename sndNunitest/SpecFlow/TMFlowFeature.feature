Feature: TMFlowFeature
	As a turnup Portal Admin \
	I would like to create , edit ,delete  time and material records
	so that i can manage employees time and meterial sucessfully

@tmtest @regression
Scenario: Create Time and Material with valid details
	Given I Logged into turnup portal sucessfully
	And I nagivate to Time and material page
	When I create time and material record.
	Then Thre record should be created sucessfully

@tmtest
Scenario: Edit Time And Material With Valid Details
Given I Logged into turnup portal sucessfully
And I nagivate to Time and material page
When I Edit the time and material record
Then There record should be edited sucessfully

@tmtest
Scenario: delete Time and Material record with valid details
Given I Logged into turnuo portal sucessfully
And I nagivate to Time and material page
When I delete the time and marerial record
Then there record should be deleted sucessfully.


