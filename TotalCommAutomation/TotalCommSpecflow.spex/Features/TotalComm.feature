Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](TotalCommSpecflow.spex/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Download and install TotalCommand 
	Given the URL https://www.totalcommander.ch/beta/tc1050x64_b1.exe
	When the download is finnished
	Then instal the app