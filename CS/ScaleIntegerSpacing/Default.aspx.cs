using System;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

namespace ScaleIntegerSpacing {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);

            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            DashboardObjectDataSource dataSource = new DashboardObjectDataSource("Data");
            dataSource.DataId = "odsSales";
            dataSource.ComponentName = "objData";
            dataSource.DataSource = typeof(ViewModel);
            dataSource.DataMember = "CreateData";
            dataSourceStorage.RegisterDataSource(dataSource.ComponentName, dataSource.SaveToXml());

            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage);
        }

        protected void ASPxDashboard1_DataLoading(object sender, DataLoadingWebEventArgs e) {
            //if(e.DataId == "odsSales") {
            //    e.Data = ViewModel.CreateData();
            //}
        }
    }
}