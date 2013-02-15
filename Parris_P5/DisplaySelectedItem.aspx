<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplaySelectedItem.aspx.cs" Inherits="DisplaySelectedItem" Debug="true" Trace="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
The selected category is <asp:Label ID="lblCoolerCat" runat="server" 
        Font-Size="X-Large"></asp:Label>
    <br />
&nbsp;
<table>
<tr>
<td>
    <asp:GridView ID="grdvCoolerCategories" runat="server" 
        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="CoolerCategoryCode" 
                DataNavigateUrlFormatString="ItemsInSelectedCategory.aspx?qryCategoryCode={0}" 
                DataTextField="CoolerCategoryName" Text="Steel Belted Coolers" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    </td>
<td> <asp:Image ID="imgCooler" runat="server" />  <table>
    <tr>
    <td>Model No:</td>
    <td>
        <asp:Label ID="lblCoolerModelNo" runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
    <td>Cooler Name:</td>
    <td>
        <asp:Label ID="lblCoolerName" runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
    <td>Descrption:</td>
    <td>
        <asp:Label ID="lblCoolerDescription" runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
    <td>Category:</td>
    <td>
        <asp:Label ID="lblCoolerCategory" runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
    <td>Price:</td>
    <td>
        <asp:Label ID="lblCoolerPrice" runat="server"></asp:Label>
        </td>
    </tr>
    
    </table></td>
</tr>
</table>


 
    
    </form>
</body>
</html>
