# Dashboard for MVC - How to create a custom dashboard controller

The example shows how to create a custom dashboard controller for the [Web Dashboard](https://docs.devexpress.com/Dashboard/16977/web-dashboard/aspnet-mvc-dashboard-extension) in an ASP.NET MVC application.

Inherit the [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController) class to create a custom dashboard controller. Pass its name to the [RouteCollectionExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.RouteCollectionExtension.MapDashboardRoute(System.Web.Routing.RouteCollection-System.String-System.String-System.String--)) method when you configure routing and to the [DashboardExtensionSettings.ControllerName](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardExtensionSettings.ControllerName) property when you configure a control on the page. 

In this example, the custom controller name is `DefaultDashboard`.

<!-- default file list -->
## Files to Look at

* [DashboardConfig.cs](./CS/MvcCustomController/App_Start/DashboardConfig.cs)
* [DefaultDashboardController.cs](./CS/MvcCustomController/Controllers/DefaultDashboardController.cs)
* [Index.cshtml](./CS/MvcCustomController/Views/Home/Index.cshtml)
<!-- default file list end -->

## Documentation

- [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController)