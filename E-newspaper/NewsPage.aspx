<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="NewsPage.aspx.cs" Inherits="NewsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        margin-left: 40px;
    }
    .style8
    {
        width: 58px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td colspan="3" style="text-align: center">
            <asp:Label ID="LblTitl" runat="server" ForeColor="Black"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style7">
            <asp:Label ID="Lblatetime" runat="server" ForeColor="Black"></asp:Label>
        &nbsp;,</td>
        <td class="style8">
            <asp:Label ID="Lblcity" runat="server" ForeColor="Black"></asp:Label>
        </td>
        <td rowspan="2">
            <asp:TextBox ID="TextBox1" runat="server" ForeColor="Yellow" Height="159px" 
                TextMode="MultiLine" Width="592px" BackColor="Transparent" Font-Bold="True" 
                Font-Size="Medium"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7" colspan="2">
            <asp:Image ID="Image1" runat="server" Height="124px" Width="127px" />
        </td>
    </tr>
    </table>
</asp:Content>

