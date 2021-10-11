<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579305/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T526629)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for MVC - How to create a custom dashboard controller

You can do one of the following to prevent inadvertent or unauthorized dashboard modifications and protect dashboards stored on a server:

- Handle the [DashboardConfigurator.VerifyClientTrustLevel](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.VerifyClientTrustLevel) event and set [e.ClientTrustLevel](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.VerifyClientTrustLevelEventArgs.ClientTrustLevel) to `Restricted` mode.
- Derive a custom dashboard controller from [RestrictedDashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.RestrictedDashboardController) instead of [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController).

The example shows how to create a restricted dashboard controller for the [Web Dashboard](https://docs.devexpress.com/Dashboard/16977/web-dashboard/aspnet-mvc-dashboard-extension) in an ASP.NET MVC application.

## Example Description

Inherit the [DashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardController) class to create a custom dashboard controller. Pass its name to the [RouteCollectionExtension.MapDashboardRoute](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.RouteCollectionExtension.MapDashboardRoute(System.Web.Routing.RouteCollection-System.String-System.String-System.String--)) method when you configure routing and to the [DashboardExtensionSettings.ControllerName](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.DashboardExtensionSettings.ControllerName) property when you configure a control on the page. 

In this example, the custom controller name is `DefaultDashboard`.

<!-- default file list -->
## Files to Look At

* [DashboardConfig.cs](./CS/MvcCustomController/App_Start/DashboardConfig.cs#L12) (VB: [DashboardConfig.vb](./VB/MvcCustomController/App_Start/DashboardConfig.vb#L10))
* [DefaultDashboardController.cs](./CS/MvcCustomController/Controllers/DefaultDashboardController.cs)  (VB: [DefaultDashboardController.vb](./VB/MvcCustomController/Controllers/DefaultDashboardController.vb))
* [Index.cshtml](./CS/MvcCustomController/Views/Home/Index.cshtml#L7)  (VB: [Index.vbhtml](./VB/MvcCustomController/Views/Home/Index.vbhtml#L6))
<!-- default file list end -->

## Documentation

- [RestrictedDashboardController](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Mvc.RestrictedDashboardController)
- [Security Considerations in Web](https://docs.devexpress.com/Dashboard/118651/designer-and-viewer-applications/web-dashboard/security-considerations)

## More Examples

- [Dashboard for ASP.NET Core - How to create a куыекшсеув dashboard controller](https://github.com/DevExpress-Examples/asp-net-core-dashboard-restricted-controller)
- [Dashboard for MVC - How to use separate server-side settings for different views](https://github.com/DevExpress-Examples/dashboard-for-mvc-use-separate-server-side-settings-for-different-views)
- [Dashboard for MVC - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)
- [Dashboard for MVC - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
