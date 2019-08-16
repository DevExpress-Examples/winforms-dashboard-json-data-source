Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.Json
Imports DevExpress.XtraEditors
Imports System

Namespace DashboardJsonExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			InitializeDashboard()
			dashboardDesigner1.ReloadData()
		End Sub

		Public Sub InitializeDashboard()
			Dim dashboard As New Dashboard()
			Dim jsonDataSource As DashboardJsonDataSource = CreateJsonDataSourceFromWeb()
			'DashboardJsonDataSource jsonDataSource = CreateJsonDataSourceFromFile();
			'DashboardJsonDataSource jsonDataSource = CreateJsonDataSourceFromString();

			dashboard.DataSources.Add(jsonDataSource)

			Dim pivot As New PivotDashboardItem()
			pivot.DataSource = jsonDataSource
			pivot.Rows.Add(New Dimension("ContactTitle"))
			pivot.Columns.Add(New Dimension("Country"))
			pivot.Values.Add(New Measure("Id", SummaryType.Count))

			Dim chart As New ChartDashboardItem()
			chart.DataSource = jsonDataSource
			chart.Arguments.Add(New Dimension("Country"))
			chart.Panes.Add(New ChartPane())
			Dim theSeries As New SimpleSeries(SimpleSeriesType.Bar)
			theSeries.Value = New Measure("Id", SummaryType.Count)
			chart.Panes(0).Series.Add(theSeries)

			dashboard.Items.AddRange(pivot, chart)
			dashboard.RebuildLayout()
			dashboard.LayoutRoot.Orientation = DashboardLayoutGroupOrientation.Vertical
			dashboardDesigner1.Dashboard = dashboard
		End Sub

		Public Shared Function CreateJsonDataSourceFromWeb() As DashboardJsonDataSource
			Dim jsonDataSource = New DashboardJsonDataSource()
			jsonDataSource.JsonSource = New UriJsonSource(New Uri("http://northwind.servicestack.net/customers.json"))
			jsonDataSource.RootElement = "Customers"
			jsonDataSource.Fill()
			Return jsonDataSource
		End Function

		Public Shared Function CreateJsonDataSourceFromFile() As DashboardJsonDataSource
			Dim jsonDataSource = New DashboardJsonDataSource()
			Dim fileUri As New Uri("customers.json", UriKind.RelativeOrAbsolute)
			jsonDataSource.JsonSource = New UriJsonSource(fileUri)
			jsonDataSource.RootElement = "Customers"
			jsonDataSource.Fill()
			Return jsonDataSource
		End Function

		Public Shared Function CreateJsonDataSourceFromString() As DashboardJsonDataSource
			Dim jsonDataSource = New DashboardJsonDataSource()
			Dim json As String = "{""Customers"":[{""Id"":""ALFKI"",""CompanyName"":""Alfreds Futterkiste"",""ContactName"":""Maria Anders"",""ContactTitle"":""Sales Representative"",""Address"":""Obere Str. 57"",""City"":""Berlin"",""PostalCode"":""12209"",""Country"":""Germany"",""Phone"":""030-0074321"",""Fax"":""030-0076545""}],""ResponseStatus"":{}}"
			jsonDataSource.JsonSource = New CustomJsonSource(json)
			jsonDataSource.RootElement = "Customers"
			jsonDataSource.Fill()
			Return jsonDataSource
		End Function
	End Class
End Namespace
