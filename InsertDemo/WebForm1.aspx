<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="InsertDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="name" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="city" runat="server" Text="City"></asp:Label>
        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
