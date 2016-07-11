<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesForm.aspx.cs" Inherits="AppWebForm.CookiesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter text for cookies"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="128px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>  
    </form>
</body>
</html>
