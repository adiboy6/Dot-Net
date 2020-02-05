<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistrationForm.aspx.cs" Inherits="Registration_Form.UserRegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            float: right;
        }
        .auto-style2 {
            text-align: right;
            width: 715px;
        }
        .auto-style3 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <table align="right" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="0">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Date of Birth"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Country"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="CountryDropDownList" runat="server" DataTextField="Country_Name" DataValueField="Country_Id" AppendDataBoundItems="true" OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select Country--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="State"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="StateDropDownList" runat="server" DataTextField="State_Name" DataValueField="State_Id" AppendDataBoundItems="true" OnSelectedIndexChanged="StateDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select State--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="CityDropDownList" runat="server" DataTextField="City_Name" DataValueField="City_Id" AppendDataBoundItems="true" OnSelectedIndexChanged="CityDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select City--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="Stream"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Value="1">.Net</asp:ListItem>
                            <asp:ListItem Value="0">Java</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
