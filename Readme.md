<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/202766252/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/DashboardJsonExample/Form1.cs) (VB: [Form1.vb](./VB/DashboardJsonExample/Form1.vb))
<!-- default file list end -->

# How to Bind a Dashboard to the JSON Data Source at Runtime

This example creates a dashboard at runtime, binds it to the [DashboardJsonDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource) and displays it in the [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) control.

The code includes three methods that create data sources to retrieve data from a web JSON endpoint, from a file and from a string. Initially the data is obtained from web, but you can modify the code to comment out the method call and uncomment the call to another method.

![](/images/screenshot.png)
