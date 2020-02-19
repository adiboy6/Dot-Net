<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Registration_Form.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            height: 47px;
        }
        .auto-style3 {
            text-align: center;
            height: 44px;
        }
        .auto-style7 {
            text-align: center;
            height: 44px;
            width: 640px;
        }
        .auto-style8 {
            text-align: left;
            height: 57px;
        }
        .auto-style9 {
            text-align: center;
            width: 640px;
            height: 47px;
        }
        .auto-style10 {
            text-align: center;
            width: 640px;
            height: 57px;
        }
        .newStyle1 {
            padding-left: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="UsernameTextBox" runat="server" ClientIDMode="AutoID" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Width="184px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" draggable="false" style="padding-left: 100px">&nbsp;<asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" Width="59px" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="ResetButton" runat="server" Text="Reset" />
                    &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
