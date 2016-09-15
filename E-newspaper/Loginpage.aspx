<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Loginpage.aspx.cs" Inherits="Loginpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
            font-family: "Comic Sans MS";
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 383px;
            margin-left: 80px;
        }
        .style4
        {
            width: 300px;
        }
        .style5
        {
            font-size: medium;
            font-family: "Comic Sans MS";
        }
        .style6
        {
            color: #993366;
        }
        .style7
        {
            height: 23px;
        }
        .style8
        {
            height: 19px;
        }
    </style>
</head>
<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">
    <div style="text-align: center; background-color: #0099FF;">
    
        &nbsp;&nbsp;<span class="style1"><strong>&nbsp;&nbsp; <span class="style6">Admin 
        Login Page</span></strong></span></div>
    <table cellpadding="0" cellspacing="0" class="style2">
        <tr>
            <td class="style3">
                Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtlgEmail" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td class="style4">
                Password:&nbsp;&nbsp;
                <asp:TextBox ID="Txtlgpwd" runat="server" TextMode="Password" Width="175px"></asp:TextBox>
            </td>
            <td>
                <asp:LinkButton ID="Lnklogin" runat="server" onclick="Lnklogin_Click">Log In</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <strong>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration New Admin Account<br />
                <br />
                </strong></td>
            <td class="style4">
                <asp:Label ID="LblMsg" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            </td>
            <td class="style5" colspan="2" rowspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="Txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Re :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txtre" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style4" rowspan="4">
                &nbsp;</td>
            <td rowspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Position :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txtpos" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Department :&nbsp;&nbsp;
                <asp:TextBox ID="Txtdept" runat="server" ></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Address :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txtadd" runat="server" Height="69px" TextMode="MultiLine" 
                    Width="202px"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="style2">
        <tr>
            <td>
                <table class="style2">
                    <tr>
                        <td class="style7">
                        </td>
                    </tr>
                    <tr>
                        <td>
                            State :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="Txtstate" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style8">
            </td>
        </tr>
        <tr>
            <td>
                Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                <asp:TextBox ID="Txtph" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
             &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Btnsgnup" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC0000" Text="SignUp" onclick="Btnsgnup_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
