<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="ASP_Assignment1_12thMar.Validators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            width: 168px;
        }
        .auto-style3 {
            height: 29px;
            width: 180px;
        }
        .auto-style4 {
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label9" runat="server" Text="Registration Form" BackColor="#FF33CC" BorderColor="#660033" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Red" Height="50px" Width="100%"></asp:Label> 
                    <br /> 
            <table class="auto-style1"> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label1" runat="server" Text="Insert your details: " Height="30px"></asp:Label> 
                    </td> 
                    <td class="auto-style4">&nbsp;</td> 
                    <td>&nbsp;</td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label> 
                    </td> 
                    <td class="auto-style4"> 
                        <asp:TextBox ID="name" runat="server"></asp:TextBox> 
                    </td> 
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;</td> 
                </tr> 
                <tr> 
                    <td class="auto-style1"> 
                        <asp:Label ID="Label3" runat="server" Text="Family Name: "></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="familyname" runat="server"></asp:TextBox> 
                    </td> 
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="familyname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="name" ControlToValidate="familyname" ErrorMessage=" Family name and name cannot be same" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
                    </td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    </td> 
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="address" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="address" ErrorMessage="address is atleast of 2 chars" ForeColor="Red" ValidationExpression="^[A-Za-z]{2}"></asp:RegularExpressionValidator>
                    </td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label5" runat="server" Text="City"></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="city" runat="server"></asp:TextBox> 
                    </td> 
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="city" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="city" ErrorMessage="city is atleast of 2 chars" ForeColor="Red" ValidationExpression="^[A-Za-z]{2}"></asp:RegularExpressionValidator>
                    </td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label6" runat="server" Text="Zip Code"></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="zipcode" runat="server" TextMode="Number" ></asp:TextBox> 
                    </td> 
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="zipcode" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="zipcode" ErrorMessage="shld be of 6 digits" ForeColor="Red" ValidationExpression="^[0-9]{6}"></asp:RegularExpressionValidator>
                    </td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label7" runat="server" Text="Phone"></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="phone" runat="server" TextMode="Number"></asp:TextBox> 
                    </td> 
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phone" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="phone" ErrorMessage="xx-xxxxxxx/xxx-xxxxxxx" ForeColor="Red" ValidationExpression="/[[0-9]{2}[-][0-9]{8}$|[0-9]{3}[-][0-9]{7}$]{10}/"></asp:RegularExpressionValidator>
                    </td> 
                </tr> 
                <tr> 
                    <td class="auto-style2"> 
                        <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label> 
                    </td> 
                    <td class="auto-style3"> 
                        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox> 
                    </td> 
                    <td>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="email" ErrorMessage="Enter email in crct format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td> 
                </tr> 
                <tr> 
                    <td class="auto-style2">&nbsp;</td> 
                    <td class="auto-style3">
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td> 
                    <td>&nbsp;</td> 
                </tr> 
            </table>

        </div>
    </form>
</body>
</html>
