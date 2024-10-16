<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/202766252/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Dashboard for WinForms - How to Bind a Dashboard to the JSON Data Source at Runtime

This example creates a dashboard at runtime, binds it to the [DashboardJsonDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource) and displays it in the [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) control.

The code includes three methods that create data sources to retrieve data from a web JSON endpoint, from a file and from a string. Initially the data is obtained from web, but you can modify the code to comment out the method call and uncomment the call to another method.

![](/images/screenshot.png)

## Files to Review 

* [Form1.cs](./CS/DashboardJsonExample/Form1.cs) (VB: [Form1.vb](./VB/DashboardJsonExample/Form1.vb))


## Documentation

* [JSON Data Source](https://docs.devexpress.com/Dashboard/401312/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/providing-data/json-data-source?p=netframework)
* [DashboardJsonDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource?p=netframework)

## More Examples

* [Dashboard for ASP.NET Core - How to create new JSON data sources at runtime](https://github.com/DevExpress-Examples/asp-net-core-dashboard-create-json-connections)
* [Dashboard for Web Forms - How to store JSON connections in a database](https://github.com/DevExpress-Examples/web-dashboard-how-to-store-json-connections-in-database)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-json-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-json-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
