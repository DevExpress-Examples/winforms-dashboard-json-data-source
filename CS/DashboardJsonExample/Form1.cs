using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Json;
using DevExpress.XtraEditors;
using System;

namespace DashboardJsonExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            InitializeDashboard();
            dashboardDesigner1.ReloadData();
        }

        public void InitializeDashboard()
        {
            Dashboard dashboard = new Dashboard();
            DashboardJsonDataSource jsonDataSource = CreateJsonDataSourceFromWeb();
            //DashboardJsonDataSource jsonDataSource = CreateJsonDataSourceFromFile();
            //DashboardJsonDataSource jsonDataSource = CreateJsonDataSourceFromString();

            dashboard.DataSources.Add(jsonDataSource);

            PivotDashboardItem pivot = new PivotDashboardItem();
            pivot.DataSource = jsonDataSource;
            pivot.Rows.Add(new Dimension("ContactTitle"));
            pivot.Columns.Add(new Dimension("Country"));
            pivot.Values.Add(new Measure("Id", SummaryType.Count));

            ChartDashboardItem chart = new ChartDashboardItem();
            chart.DataSource = jsonDataSource;
            chart.Arguments.Add(new Dimension("Country"));
            chart.Panes.Add(new ChartPane());
            SimpleSeries theSeries = new SimpleSeries(SimpleSeriesType.Bar);
            theSeries.Value = new Measure("Id", SummaryType.Count);
            chart.Panes[0].Series.Add(theSeries);

            dashboard.Items.AddRange(pivot, chart);
            dashboard.RebuildLayout();
            dashboard.LayoutRoot.Orientation = DashboardLayoutGroupOrientation.Vertical;
            dashboardDesigner1.Dashboard = dashboard;
        }

        public static DashboardJsonDataSource CreateJsonDataSourceFromWeb()
        {
            var jsonDataSource = new DashboardJsonDataSource();
            jsonDataSource.JsonSource = new UriJsonSource(new Uri("https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json"));
            jsonDataSource.RootElement = "Customers";
            jsonDataSource.Fill();
            return jsonDataSource;
        }

        public static DashboardJsonDataSource CreateJsonDataSourceFromFile()
        {
            var jsonDataSource = new DashboardJsonDataSource();
            Uri fileUri = new Uri("customers.json", UriKind.RelativeOrAbsolute);
            jsonDataSource.JsonSource = new UriJsonSource(fileUri);
            jsonDataSource.RootElement = "Customers";
            jsonDataSource.Fill();
            return jsonDataSource;
        }

        public static DashboardJsonDataSource CreateJsonDataSourceFromString()
        {
            var jsonDataSource = new DashboardJsonDataSource();
            string json = "{\"Customers\":[{\"Id\":\"ALFKI\",\"CompanyName\":\"Alfreds Futterkiste\",\"ContactName\":\"Maria Anders\",\"ContactTitle\":\"Sales Representative\",\"Address\":\"Obere Str. 57\",\"City\":\"Berlin\",\"PostalCode\":\"12209\",\"Country\":\"Germany\",\"Phone\":\"030-0074321\",\"Fax\":\"030-0076545\"}],\"ResponseStatus\":{}}";
            jsonDataSource.JsonSource = new CustomJsonSource(json);
            jsonDataSource.RootElement = "Customers";
            jsonDataSource.Fill();
            return jsonDataSource;
        }
    }
}
