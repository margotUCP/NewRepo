<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplication1.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:Label ID="IbIName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <asp:ListBox ID="IstLocation" runat="server">
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Hydrebad</asp:ListItem>
        </asp:ListBox>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
        <asp:CheckBox ID="chkC" runat="server" Text="C#" />
        <asp:CheckBox ID="chkASP" runat="server" Text="ASP.Net" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
