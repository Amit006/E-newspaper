<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="CatagoryPage.aspx.cs" Inherits="CatagoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            color: #FFFFFF;
        }
        .style8
        {
            color: #000000;
            font-size: x-large;
            font-family: "Comic Sans MS";
        }
        .style9
        {
            font-size: large;
            font-family: Ebrima;
            color: #000000;
        }
        .style10
        {
            width: 231px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td class="style8" colspan="2" style="text-align: center">
                <strong>Select Catagory</strong></td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Image ID="Image1" runat="server" Height="193px" Width="228px" />
            </td>
            <td>
            <center>
                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84"  PageSize="5"
                    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                   
                </asp:GridView>
                </center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7" colspan="2">
                <span class="style9"><strong>Select a Catagory Id :</strong></span>
                <asp:TextBox ID="TxtcatagoryID" runat="server" Width="88px" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnDetail" runat="server" BackColor="#99FF66" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="Maroon" Text="Details" Width="81px" 
                    onclick="BtnDetail_Click" />
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

