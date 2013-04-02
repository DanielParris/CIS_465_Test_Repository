<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddItemToInventory.aspx.cs" Inherits="Employees_AddItemToInventory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:Panel ID="pnlInput" runat="server">
     <form id="form1" runat="server">
    <h1>Add Items - Choose a Cateogry</h1>

   <table>
   <tr>
   <td>Model Number</td>
   <td>
       <asp:TextBox ID="txtCoolerModelNo" runat="server" Width="150px"></asp:TextBox>
       <asp:RequiredFieldValidator ID="rfvCoolerModelNo" runat="server" 
           ControlToValidate="txtCoolerModelNo" Display="Dynamic" 
           ErrorMessage="*You must enter a model number!" SetFocusOnError="True"></asp:RequiredFieldValidator>
       </td>
   </tr>

    <tr>
   <td>Name</td>
   <td>
       <asp:TextBox ID="txtCoolerName" runat="server" Width="151px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCoolerName" runat="server" 
           ControlToValidate="txtCoolerName" Display="Dynamic" 
           ErrorMessage="*You must enter a name!" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
   </tr>

    <tr>
   <td>Description</td>
   <td>
       <asp:TextBox ID="txtCoolerDescription" runat="server" Width="152px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCoolerDescription" runat="server" 
           ControlToValidate="txtCoolerDescription" Display="Dynamic" 
           ErrorMessage="*You must enter a description!" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
   </tr>

    <tr>
   <td>Category</td>
   <td><asp:DropDownList ID="ddlCoolerCategory" runat="server">
        <asp:ListItem Selected="True" Value="">Select a Category</asp:ListItem>
        <asp:ListItem Value="1">Steel Belted Coolers</asp:ListItem>
        <asp:ListItem Value="2">Xtreme Coolers</asp:ListItem>
        <asp:ListItem Value="3">Wheeled Coolers</asp:ListItem>
        <asp:ListItem Value="4">Soft Sided Coolers</asp:ListItem>
        <asp:ListItem Value="5">Party Stacker Coolers</asp:ListItem>
    </asp:DropDownList>
       <asp:RequiredFieldValidator ID="rfvCoolerCategory" runat="server" 
           ControlToValidate="ddlCoolerCategory" Display="Dynamic" 
           ErrorMessage="*You must select a category!" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
   </tr>

    <tr>
   <td>Price</td>
   <td>
       <asp:TextBox ID="txtCoolerPrice" runat="server" Width="151px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCoolerPrice" runat="server" 
           ControlToValidate="txtCoolerPrice" Display="Dynamic" 
           ErrorMessage="*You must enter a price!" SetFocusOnError="True"></asp:RequiredFieldValidator>
       <asp:RangeValidator ID="ravCoolerPrice" runat="server" 
           ControlToValidate="txtCoolerPrice" Display="Dynamic" 
           ErrorMessage="*Your price must be greater than 0!" 
           MaximumValue="99999999999999999" MinimumValue="0" SetFocusOnError="True"></asp:RangeValidator>
        </td>
   </tr>

    <tr>
   <td>Image File Name</td>
   <td>
       <asp:TextBox ID="txtImageFileName" runat="server" Width="154px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvImageFileName" runat="server" 
           ControlToValidate="txtImageFileName" Display="Dynamic" 
           ErrorMessage="*You must enter an image file name!" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
   </tr>
   
     <tr>
    <td>
        <asp:Button ID="butSubmit" runat="server" onclick="butSubmit_Click" 
            Text="Submit Changes" />
         </td>
    <td></td>
    </tr>
   
   </table>

    
    
    </form>
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
    <td>Image File Name: </td>
    <td>
        <asp:Label ID="lblCoolerImageFileName" runat="server"></asp:Label>
        </td>
    </tr>
    
  
    </table>
    </asp:Panel>

  
</body>
</html>
