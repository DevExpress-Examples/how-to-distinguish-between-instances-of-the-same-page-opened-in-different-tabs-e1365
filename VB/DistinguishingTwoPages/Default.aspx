<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="DistinguishingTwoPages._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dxhf" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>How to distinguish between instances of the same page opened in different tabs</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxhf:ASPxHiddenField ID="ASPxHiddenField1" runat="server">
		</dxhf:ASPxHiddenField>
		<dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text="Page ID: ">
		</dxe:ASPxLabel>
		<br />
		<dxe:ASPxLabel ID="ASPxLabel2" runat="server" Text="Enter some text:">
		</dxe:ASPxLabel>
		<dxe:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px">
		</dxe:ASPxTextBox>
		<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="Submit">
		</dxe:ASPxButton>
		<dxe:ASPxHyperLink ID="ASPxHyperLink1" runat="server" NavigateUrl="Default.aspx"
			Target="_blank" Text="New Page">
		</dxe:ASPxHyperLink>
	</div>
	</form>
</body>
</html>
