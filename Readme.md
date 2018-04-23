# How to use aggregate functions in Calculated Field expressions


This example illustrates how to calculate field values dynamically based on a group aggregated value. The following syntax is used in this case: <strong>[collection][condition].Function([Field])</strong><br>To calculate a group sum (for example), use the approach from the <a href="https://www.devexpress.com/Support/Center/p/T211184">How to conditionally suppress summary footer cell painting by using formatting rules</a> code example. Please note that you can use the '^' symbol in expressions to refer to a currently processed data record.<br><br>In this code example the following expressions were used:<br><br><em>calcUnitsInStockSum</em><br><strong>[][[CategoryID] == [^.CategoryID]].Sum([UnitsInStock])<br><br></strong><em>calcUnitsInStockPercentage<br></em><strong>[UnitsInStock] / [calcUnitsInStockSum]</strong><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-aggregate-functions-in-calculated-field-expressions-t317187/14.2.6+/media/703a6f0a-5432-11e6-80bf-00155d62480c.png"><br><strong>See also</strong>

* <a href="https://www.devexpress.com/Support/Center/Example/Details/T371460">How to calculate a weighted average function</a>

<br/>


