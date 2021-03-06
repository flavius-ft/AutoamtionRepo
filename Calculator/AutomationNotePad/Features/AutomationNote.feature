Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](AutomationNotePad/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Enter text in note pad, clik X and don's save
	Given open notepad
	When the text "Hello" is enterd
	Then close tha app

Scenario: Open notepad, go to Edit and change the theme to dark
    Given open notepad
	When change the theme to dark
	Then close the app