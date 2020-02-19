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
        .auto-style6 {
            text-align: center;
            width: 715px;
            height: 83px;
        }
        .auto-style7 {
            text-align: left;
            height: 83px;
        }
        .auto-style10 {
            text-align: right;
            width: 715px;
            height: 58px;
        }
        .auto-style11 {
            text-align: left;
            height: 58px;
        }
        .auto-style12 {
            text-align: right;
            width: 715px;
            height: 50px;
        }
        .auto-style13 {
            text-align: left;
            height: 50px;
        }
        .auto-style14 {
            height: 64px;
            text-align: justify;
        }
        .auto-style15 {
            text-align: right;
            width: 715px;
            height: 64px;
        }
        .auto-style16 {
            text-align: right;
            width: 715px;
            height: 57px;
        }
        .auto-style17 {
            text-align: left;
            height: 57px;
        }
        .auto-style18 {
            text-align: right;
            width: 715px;
            height: 44px;
        }
        .auto-style19 {
            text-align: left;
            height: 44px;
        }
        .auto-style20 {
            text-align: right;
            width: 715px;
            height: 51px;
        }
        .auto-style21 {
            text-align: left;
            height: 51px;
        }
        .auto-style22 {
            text-align: right;
            width: 715px;
            height: 54px;
        }
        .auto-style23 {
            text-align: left;
            height: 54px;
        }
        .auto-style24 {
            text-align: right;
        }
    </style>
    <script src="js\FormValidate_JS.js" type="text/javascript"></script> 
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.min.js"></script>
    <script src="js\FormValidate_jQ.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="right" class="auto-style1">
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
                        <asp:Label ID="FirstNameValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
                        <asp:Label ID="LastNameValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <div class="auto-style24">
                        <asp:RadioButtonList ID="GenderRadioButtonList" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="0">Female</asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
                        <asp:Label ID="GenderValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Date of Birth"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Calendar ID="DOBCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                        <asp:Label ID="DOBValidationLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="Label5" runat="server" Text="Country"></asp:Label>
                    </td>
                    <td class="auto-style17">
                        <asp:DropDownList ID="CountryDropDownList" runat="server" DataTextField="Country_Name" DataValueField="Id" AppendDataBoundItems="true" OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select Country--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="CountryValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        <asp:Label ID="Label6" runat="server" Text="State"></asp:Label>
                    </td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="StateDropDownList" runat="server" DataTextField="State_Name" DataValueField="Id" AppendDataBoundItems="true" OnSelectedIndexChanged="StateDropDownList_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>--Select State--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="StateValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style21">
                        <asp:DropDownList ID="CityDropDownList" runat="server" DataTextField="City_Name" DataValueField="Id" AppendDataBoundItems="true" AutoPostBack="true">
                            <asp:ListItem>--Select City--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="CityValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="Stream"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:CheckBoxList ID="StreamCheckBoxList" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">.Net</asp:ListItem>
                            <asp:ListItem Value="0">Java</asp:ListItem>
                        </asp:CheckBoxList>
                        <asp:Label ID="StreamValidityLabel" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label9" runat="server" Text="Phone Number"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" TextMode="Phone" Width="210px"></asp:TextBox>
                        <asp:Label ID="PhoneNoValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label10" runat="server" Text="E-Mail"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="EMailTextBox" runat="server" TextMode="Email" Width="213px" ValidateRequestMode="Enabled"></asp:TextBox>
                        <asp:Label ID="EMailValidateLabel" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" OnClientClick="javascript:return validateUser()" />
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
