Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace ScaleIntegerSpacing

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardFileStorage As DashboardFileStorage = New DashboardFileStorage("~/App_Data/Dashboards")
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)
            Dim dataSourceStorage As DataSourceInMemoryStorage = New DataSourceInMemoryStorage()
            Dim dataSource As DashboardObjectDataSource = New DashboardObjectDataSource("Data")
            dataSource.ComponentName = "objData"
            dataSource.DataSource = GetType(ViewModel)
            dataSource.DataMember = "CreateData"
            dataSourceStorage.RegisterDataSource(dataSource.ComponentName, dataSource.SaveToXml())
            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)
        End Sub

        Protected Sub ASPxDashboard1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingWebEventArgs)
        'if(e.DataSourceName == "SalesPersonData") {
        '    e.Data = SalesPersonData.CreateData();
        '}
        End Sub
    End Class
End Namespace
