# ADS103 Assessment 1
This project is created for ADS103 assignment 1 at torrens university for student James Simpson
https://github.com/NightcrawlerEX/ADS103_Assessment_1
Student Number: A00125081

I have installed .NET 8.0 for this project

This project was created via "dotnet new console"

The .gitignore file was downloaded from https://github.com/github/gitignore/blob/main/VisualStudio.gitignore

I have included "PlantUML.txt" which contains the UML. To produce the graphic use PlantUML Server located at URL "https://www.plantuml.com/plantuml/uml/"

We will be using a value object paradigm throughout. See "ValueObjects" folder 

## Step 2 - Custom Attributes

Below is the rationale that I have used
- name: Common to all. Therefore in base class "Character"
- hitPoints: Common to all. Therefore in base class "Character"
- manaPoints: I have played many games where the warrior also has mana. But I don't feel that is the case in this game so it is only included in "Mage"
- strength: Common to all. Therefore in base class "Character"
- defence: Common to all. Therefore in base class "Character"
- ragePoints: I feel this is a warrior thing. Therefore in "Warrior" and derived classes
- fireballDamage: Sounds like a mage thing. Therefore in class "Mage"
- healAmount: Sounds like its related to healing. Therefore in class "Paladin"