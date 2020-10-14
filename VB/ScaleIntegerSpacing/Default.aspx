<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ScaleIntegerSpacing.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height:100%">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function onItemWidgetOptionsUpdating(s, e) {
            if (e.ItemName == "chartDashboardItem1") {
                var widget = e.GetWidget();
                // Set this option for each pane
                widget.option('valueAxis[0].allowDecimals', false);
            }
        }
    </script>

</head>
<body style="height:100%">
    <form id="form1" runat="server" style="height:100%">
            <dx:ASPxDashboard ID="ASPxDashboard1" ClientInstanceName="webDashboard" runat="server" WorkingMode="Viewer" Height="100%"
                OnDataLoading="ASPxDashboard1_DataLoading">
                <ClientSideEvents ItemWidgetCreated="onItemWidgetOptionsUpdating" ItemWidgetUpdated="onItemWidgetOptionsUpdating"/>
            </dx:ASPxDashboard>            

    </form>
</body>
</html>