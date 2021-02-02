<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="LocalMiniMarket.Product" %>


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
            ProductID
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            brandName</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            ProductName
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            ProductType</p>
        <p>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            stock</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            comingPrice
        </p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            salePrice</p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Clicked" Text="CalculateSalePrice" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Clicked" Text="Insert" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Clicked" Text="Delete" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Clicked" Text="Update" />
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fill gridview" />
        </p>

        <p>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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






