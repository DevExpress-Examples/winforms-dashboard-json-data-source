<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/DashboardJsonExample/Form1.cs) (VB: [Form1.vb](./VB/DashboardJsonExample/Form1.vb))
<!-- default file list end -->

# How to Bind a Dashboard to the JSON Data Source at Runtime

This example creates a simple dashboard at runtime, binds it to the [DashboardJsonDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource) and displays it in the [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) control.

The code includes three methods that create data sources to retrieve data from a web JSON endpoint, from a file and from a string. Initially the data is obtained from web, but you can modify the code to comment out the method call and uncomment the call to another method.

![](/images/screenshot.png)