<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="ProtectedFolder_LoginPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Login Page<br />
        <br />
        User Name &nbsp;<asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox><br />
        <br />
        Password &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        <br />
        <asp:Button ID="butLogin" runat="server" OnClick="butLogin_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblErrorDisplay" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></div>
    </form>
</body>
</html>
