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
        .auto-style4 {
            text-align: right;
            width: 715px;
            height: 26px;
        }
        .auto-style5 {
            text-align: left;
            height: 26px;
        }
        .auto-style6 {
            text-align: center;
            width: 715px;
            height: 83px;
        }
        .auto-style7 {
            text-align: left;
            height: 83px;
        }
        .auto-style8 {
            text-align: right;
            width: 715px;
            height: 30px;
        }
        .auto-style9 {
            text-align: left;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="right" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Label ID="FirstNameValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Label ID="LastNameValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="0">Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="GenderValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
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
                        <asp:DropDownList ID="CountryDropDownList" runat="server" DataTextField="Country_Name" DataValueField="Id" AppendDataBoundItems="true" OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select Country--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="State"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="StateDropDownList" runat="server" DataTextField="State_Name" DataValueField="Id" AppendDataBoundItems="true" OnSelectedIndexChanged="StateDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select State--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="CityDropDownList" runat="server" DataTextField="City_Name" DataValueField="Id" AppendDataBoundItems="true" OnSelectedIndexChanged="CityDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select City--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="Stream"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">.Net</asp:ListItem>
                            <asp:ListItem Value="0">Java</asp:ListItem>
                        </asp:CheckBoxList>
                        <asp:Label ID="StreamValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label9" runat="server" Text="Phone Number"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" TextMode="Phone" Width="210px"></asp:TextBox>
                        <asp:Label ID="PhoneNoValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                        <asp:RegularExpressionValidator ID="PhoneNumberRegularExpressionValidator" runat="server" ControlToValidate="PhoneNumberTextBox" ErrorMessage="Enter a valid Phone number" ForeColor="Red" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label10" runat="server" Text="E-Mail"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" Width="213px" ValidateRequestMode="Enabled"></asp:TextBox>
                        <asp:Label ID="EMailValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Reset" />
&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
