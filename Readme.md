<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579305/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T526629)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for MVC - How to create a custom dashboard controller

The example shows how to create a custom dashboard controller for the [Web Dashboard](https://docs.devexpress.com/Dashboard/16977/web-dashboard/aspnet-mvc-dashboard-extension) in an ASP.NET MVC application.

Inherit the [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController) class to create a custom dashboard controller. Pass its name to the [RouteCollectionExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.RouteCollectionExtension.MapDashboardRoute(System.Web.Routing.RouteCollection-System.String-System.String-System.String--)) method when you configure routing and to the [DashboardExtensionSettings.ControllerName](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardExtensionSettings.ControllerName) property when you configure a control on the page. 

In this example, the custom controller name is `DefaultDashboard`.


<!-- default file list -->
## Files to Look At

* [DashboardConfig.cs](./CS/MvcCustomController/App_Start/DashboardConfig.cs#L12)
* [DefaultDashboardController.cs](./CS/MvcCustomController/Controllers/DefaultDashboardController.cs)
* [Index.cshtml](./CS/MvcCustomController/Views/Home/Index.cshtml#L8)
<!-- default file list end -->

## Documentation

- [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController)

## More Examples

- [Dashboard for ASP.NET Core - How to create a custom dashboard controller](https://github.com/DevExpress-Examples/dashboard-for-asp-net-core-custom-dashboard-controller)
- [Dashboard for MVC - How to use separate server-side settings for different views](https://github.com/DevExpress-Examples/dashboard-for-mvc-use-separate-server-side-settings-for-different-views)
- [Dashboard for MVC - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)
- [Dashboard for MVC - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
