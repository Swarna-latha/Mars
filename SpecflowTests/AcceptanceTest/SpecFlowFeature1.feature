﻿Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings


Scenario: Check if user could be able to add Education
	Given I clicked on the Education tab under Profile page
	When I add all details of my college
	Then my education background details should be displayed under description
	