<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Registration_Form.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 520px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="WelcomeLabel" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" ForeColor="Black" Text="Welcome"></asp:Label>
            <asp:Label ID="UsernameLabel" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>
