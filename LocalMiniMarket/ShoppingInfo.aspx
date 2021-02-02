<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingInfo.aspx.cs" Inherits="LocalMiniMarket.ShoppingInfo" %>

<!DOCTYPE html>

<html>
<head>
    <title>LocalMiniMarket</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
</head>

<body>
    <form id="form1" runat="server">
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        ShoppingID<br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        CustomerID<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_ClickInfo" Text="Insert" />
        
    </form>
</body>
</html>
