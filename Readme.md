<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603847/14.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T317187)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/TestCalculatedFieldSummary/Form1.cs) (VB: [Form1.vb](./VB/TestCalculatedFieldSummary/Form1.vb))
* [XtraReport1.cs](./CS/TestCalculatedFieldSummary/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/TestCalculatedFieldSummary/XtraReport1.vb))
<!-- default file list end -->
# How to use aggregate functions in Calculated Field expressions


This example illustrates how to calculate field values dynamically based on a group aggregated value. The following syntax is used in this case: <strong>[collection][condition].Function([Field])</strong><br>To calculate a group sum (for example), use the approach from the <a href="https://www.devexpress.com/Support/Center/p/T211184">How to conditionally suppress summary footer cell painting by using formatting rules</a> code example. Please note that you can use the '^' symbol in expressions to refer to a currently processed data record.<br><br>In this code example the following expressions were used:<br><br><em>calcUnitsInStockSum</em><br><strong>[][[CategoryID] == [^.CategoryID]].Sum([UnitsInStock])<br><br></strong><em>calcUnitsInStockPercentage<br></em><strong>[UnitsInStock] / [calcUnitsInStockSum]</strong><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-aggregate-functions-in-calculated-field-expressions-t317187/14.2.6+/media/703a6f0a-5432-11e6-80bf-00155d62480c.png"><br><strong>See also</strong>

* <a href="https://www.devexpress.com/Support/Center/Example/Details/T371460">How to calculate a weighted average function</a>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-aggregated-function-calculated-field&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-aggregated-function-calculated-field&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
