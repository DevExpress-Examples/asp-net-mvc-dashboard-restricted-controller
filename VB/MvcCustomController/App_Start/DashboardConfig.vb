Imports System.Web.Hosting
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.Excel
Imports DevExpress.DataAccess.Sql

Public Class DashboardConfig
    Public Shared Sub RegisterService(routes As RouteCollection)
		routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")

		Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
		DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

		' Uncomment this string to allow end users to create new data sources based on predefined connection strings.
		'DashboardConfigurator.Default.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());

		Dim dataSourceStorage As New DataSourceInMemoryStorage()

		' Registers an SQL data source.
		Dim sqlDataSource As New DashboardSqlDataSource("SQL Data Source", "NWindConnectionString")
		Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("SalesPerson").SelectAllColumns().Build("Sales Person")
		sqlDataSource.Queries.Add(query)
		dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml())

		' Registers an Excel data source.
		Dim excelDataSource As New DashboardExcelDataSource("Excel Data Source")
		excelDataSource.FileName = HostingEnvironment.MapPath("~/App_Data/Sales.xlsx")
		excelDataSource.SourceOptions = New ExcelSourceOptions(New ExcelWorksheetSettings("Sheet1"))
		dataSourceStorage.RegisterDataSource("excelDataSource", excelDataSource.SaveToXml())

		DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
	End Sub
End Class