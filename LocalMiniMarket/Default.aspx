<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalMiniMarket.WebForm3" %>


<!DOCTYPE html>

<html>
    <head>
<title>LocalMiniMarket</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
</head>

<body>
   
    <form id="form1" runat="server">
        <div class="content">
  <div id="top">
  </div>
  <div id="header">
   
    <div class="title">
      <h1>Local Mini Market Interface</h1>
      <h2>Welcome to database</h2>
        </div>
         </div>
            </div>
        <div id="subheader">
    <div id="menu">
      <ul>
        <li><a href="Product.aspx">Product</a></li>
        <li><a href="Customer.aspx">Customer</a></li>
        <li><a href="Shopping.aspx">Shopping</a></li>
        <li><a href="ShoppingInfo.aspx">ShoppingInfo</a></li>    
      </ul>
    </div>
  </div>
        
        <asp:Label ID="lblNotFound" runat="server"></asp:Label>
        
        <br />
        Please choose your employeeName<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click1" />
        
    </form>
</body>
</html>
