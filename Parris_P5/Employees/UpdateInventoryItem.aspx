<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateInventoryItem.aspx.cs" Inherits="Employees_UpdateInventoryItem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


    <asp:Panel ID="pnlInput" runat="server">

      
  <h1>Update Items</h1>

  <table>
  <tr>
  <td>Model Number: </td>
  <td>
      <asp:TextBox ID="txtCoolerModelNo" runat="server"></asp:TextBox>
      </td>
  </tr>

   <tr>
  <td>Name: </td>
  <td>
      <asp:TextBox ID="txtCoolerName" runat="server"></asp:TextBox>
       </td>
  </tr>

   <tr>
  <td>Description: </td>
  <td>
      <asp:TextBox ID="txtCoolerDescription" runat="server"></asp:TextBox>
       </td>
  </tr>

   <tr>
  <td>Category: </td>
  <td>
      <asp:TextBox ID="txtCoolerCategory" runat="server"></asp:TextBox>
       </td>
  </tr>

   <tr>
  <td>Price: </td>
  <td>
      <asp:TextBox ID="txtCoolerPrice" runat="server"></asp:TextBox>
       </td>
  </tr>

   <tr>
  <td>Image File Name</td>
  <td>
      <asp:TextBox ID="txtImageFileName" runat="server"></asp:TextBox>
       </td>
  </tr>
  <tr>
  <td>
      <asp:Button ID="butUpdate" runat="server" onclick="butUpdate_Click" 
          Text="Update This Info" />
      </td>
  <td>
      <asp:HyperLink ID="HyperLink1" runat="server" 
          NavigateUrl="UpdateInventoryItem_Start.aspx">Go Back</asp:HyperLink>
      </td>
  </tr>
  <tr>
  <td></td>
  <td>&nbsp;</td>
  </tr>

  </table>

    </asp:Panel>

    <asp:Panel ID="pnlDisplay" runat="server">

     <table>
  <tr>
  <td>Model Number: </td>
  <td>
      <asp:Label ID="lblCoolerModelNo" runat="server"></asp:Label>
      </td>
  </tr>

   <tr>
  <td>Name: </td>
  <td>
      <asp:Label ID="lblCoolerName" runat="server"></asp:Label>
       </td>
  </tr>

   <tr>
  <td>Description: </td>
  <td>
      <asp:Label ID="lblCoolerDescription" runat="server"></asp:Label>
       </td>
  </tr>

   <tr>
  <td>Category: </td>
  <td>
      <asp:Label ID="lblCoolerCategory" runat="server"></asp:Label>
       </td>
  </tr>

   <tr>
  <td>Price: </td>
  <td>
      <asp:Label ID="lblCoolerPrice" runat="server"></asp:Label>
       </td>
  </tr>

   <tr>
  <td>Image File Name</td>
  <td>
      <asp:Label ID="lblCoolerImageFileName" runat="server"></asp:Label>
       </td>
  </tr>
  <tr>
  <td>
      &nbsp;</td>
  <td>
      <asp:HyperLink ID="HyperLink2" runat="server" 
          NavigateUrl="UpdateInventoryItem_Start.aspx">Go Back</asp:HyperLink>
      </td>
  </tr>
  <tr>
  <td><b>Your page has been updated.</b></td>
  <td>&nbsp;</td>
  </tr>

  </table>

    </asp:Panel>

    </form>
</body>
</html>
