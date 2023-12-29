<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ScaleIntegerSpacing/Default.aspx) (VB: [Default.aspx](./VB/ScaleIntegerSpacing/Default.aspx))
* [Default.aspx.cs](./CS/ScaleIntegerSpacing/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ScaleIntegerSpacing/Default.aspx.vb))
* [Global.asax](./CS/ScaleIntegerSpacing/Global.asax) (VB: [Global.asax](./VB/ScaleIntegerSpacing/Global.asax))
* [Global.asax.cs](./CS/ScaleIntegerSpacing/Global.asax.cs) (VB: [Global.asax.vb](./VB/ScaleIntegerSpacing/Global.asax.vb))
* [SalesPersonData.cs](./CS/ScaleIntegerSpacing/SalesPersonData.cs) (VB: [SalesPersonData.vb](./VB/ScaleIntegerSpacing/SalesPersonData.vb))
<!-- default file list end -->
# Web Dashboard - How to make the Chart Item display only whole numbers in the Y axis' labels

To ensure better appearance, our Dashboard Chart Items automatically calculate the interval between grid lines and major tickmarks. In certain cases, automatically calculated values are not suitable. For instance, the Y axis' labels can display fractional numbers when the chart contains only whole number values - measures with the Count summary type.

Starting with version 17.2, dxChart widgets, used internally in our Web Dashboard Chart items, provide the [ValueAxis.allowDecimals](https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/dxChart/Configuration/valueAxis/#allowDecimals) option that determines whether to allow decimal values on the axis. This example illustrates how to enable this option via client-side code, so that only whole numbers are displayed in the Y axis' labels. For this, access the underlying [dxChart](https://js.devexpress.com/Documentation/15_2/ApiReference/Data_Visualization_Widgets/dxChart/) widget in the [ItemWidgetCreated](https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.ItemWidgetCreated.event) and [ItemWidgetUpdated](https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.ItemWidgetUpdated.event) event handlers and disable the allowDecimals option for all value axis in all panes.  

**Note** that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing underlying widgets.  

The following screencast demonstrates this approach and the default behavior.

![](https://raw.githubusercontent.com/DevExpress-Examples/web-dashboards-how-to-make-the-chart-item-display-only-whole-numbers-in-the-y-axis-labels-t607149/17.2.3+/media/abdda36f-9b47-4677-a480-f1582db55b6b.png)

## Documentation

* [Access to Underlying Widgets in ASP.NET Web Forms](https://docs.devexpress.com/Dashboard/117573/web-dashboard/aspnet-web-forms-dashboard-control/access-to-underlying-widgets)

## More Examples

* [Dashboard for WinForms - How to Customize the Chart Item's Axis Grid Settings](https://github.com/DevExpress-Examples/winforms-dashboards-how-to-use-custom-axis-grid-settings-in-the-chart-item-t597206)
