Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace ScaleIntegerSpacing
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)

            Dim dataSourceStorage As New DataSourceInMemoryStorage()

            Dim dataSource As New DashboardObjectDataSource("Data")
            dataSource.DataId = "odsSales"
            dataSource.ComponentName = "objData"
            dataSource.DataSource = GetType(ViewModel)
            dataSource.DataMember = "CreateData"
            dataSourceStorage.RegisterDataSource(dataSource.ComponentName, dataSource.SaveToXml())

            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)
        End Sub

        Protected Sub ASPxDashboard1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingWebEventArgs)
            'If (e.DataId = "odsSales") Then
            '    e.Data = ViewModel.CreateData()
            'End If
        End Sub
    End Class
End Namespace