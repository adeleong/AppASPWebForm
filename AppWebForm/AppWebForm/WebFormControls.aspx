<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormControls.aspx.cs" Inherits="AppWebForm.WebFormControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="SSD" Text="SSD" runat="server" />
        <asp:CheckBox ID="SixteenGB"  Text="16GB?" runat="server" />
        <asp:CheckBox ID="DualMonitor"  Text="Dual Monitor?" runat="server" />
        <hr />
        <asp:RadioButton ID="Male" Text="Male"  GroupName="Sex" runat="server" Checked="true" />
        <asp:RadioButton ID="Female"  Text="Female" GroupName="Sex" runat="server" />
        <hr />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Text="Power Windows" Value="Feature1"/>
            <asp:ListItem Text="Power Seats" Value="Feature2"/>
            <asp:ListItem Text="Fog Lights" Value="Feature3"/>
            <asp:ListItem Text="Wintor Package" Value="Feature4"/>
        </asp:CheckBoxList>
        <hr />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
             <asp:ListItem Text="Under 30" Value="Young" Selected="True"/>
             <asp:ListItem Text="30-60" Value="Middle"/>
             <asp:ListItem Text="Over 60" Value="Old"/>
        </asp:RadioButtonList>
        <hr />
          <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem Text="Item 1" Value="1"/>
             <asp:ListItem Text="Item 2" Value="2"/>
             <asp:ListItem Text="Item 3" Value="3"/>
             <asp:ListItem Text="Item 4" Value="4"/>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Summit" OnClick="Button1_Click" />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
