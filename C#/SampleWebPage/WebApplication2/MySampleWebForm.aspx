<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MySampleWebForm.aspx.cs" Inherits="WebApplication2.MySampleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 45%;
            height: 94px;
        }
        .auto-style3 {
            width: 418px;
        }
        .auto-style4 {
            width: 277px;
        }
        .auto-style5 {
            width: 278px;
        }
        .auto-style6 {
            width: 418px;
            height: 46px;
        }
        .auto-style7 {
            height: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2" draggable="false">
                <tr>
                    <td class="auto-style3" style="text-align: center; vertical-align: middle">
                        <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
                    </td>
                    <td style="text-align: center; vertical-align: middle">
                        <input id="Text1" class="auto-style4" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style6" style="vertical-align: middle; text-align: center">
                        <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
                    </td>
                    <td class="auto-style7" style="text-align: center; vertical-align: middle">
                        <input id="Password1" class="auto-style5" type="password" /></td>
                </tr>
                <tr>
                    <td style="vertical-align: middle; text-align: center">
                        <input id="Submit1" type="submit" value="submit" /></td>
                    <td style="vertical-align: middle; text-align: center">
                        <input id="Reset1" type="reset" value="reset" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
