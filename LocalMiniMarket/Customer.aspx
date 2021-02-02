<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="LocalMiniMarket.Customer" %>


<!DOCTYPE html>

<html>
<head>
    <title>LocalMiniMarket</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
</head>

<body>

    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            customerID
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            name
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            age</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            regularCus</p>
        <p>
            &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            gender</p>
        <p>
            &nbsp;<asp:Button ID="Button1Customer" runat="server" OnClick ="Button1Customer_Click" Text="Insert" />
        </p>
        <p>
            <asp:Button ID="Button2Customer" runat="server" OnClick="Button2Customer_Click" Text="Fill gridview" />
        </p>

         <p>
         <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
               </asp:GridView>
            <br />
        </p>
    </form>
</body>
</html>
