<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ScaleIntegerSpacing.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
	<title></title>

	<style type="text/css">
		html, body, form {  
			height: 100%;  
			margin: 0;  
			padding: 0;  
			overflow: hidden;  
		}
	</style>

	<script type="text/javascript">
		function onBeforeRender(s, e) {
			var dashboardControl = s.GetDashboardControl();
			var viewerApiExtension = dashboardControl.findExtension('viewer-api');
			if (viewerApiExtension)
				viewerApiExtension.on('itemWidgetOptionsPrepared', onItemWidgetOptionsPrepared);
		}

		function onItemWidgetOptionsPrepared(args) {
			if (args.itemName == "chartDashboardItem1") {
				args.options.valueAxis[0].allowDecimals = false;
			}
		}
	</script>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxDashboard ID="ASPxDashboard1" runat="server" ClientInstanceName="webDashboard" 
			WorkingMode="Viewer" Height="100%" OnDataLoading="ASPxDashboard1_DataLoading">
			<ClientSideEvents BeforeRender="onBeforeRender" />
		</dx:ASPxDashboard>
	</form>
</body>
</html>