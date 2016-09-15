<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewsInsertion.aspx.cs" Inherits="NewsInsertion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        font-size: large;
        font-family: "Comic Sans MS";
        color: #FFCC00;
    }
    .style3
    {
        font-size: x-large;
        color: #FFCC00;
    }
    .style6
    {
        color: #FFCC00;
    }
    .style7
    {
        font-family: "Comic Sans MS";
        color: #FFCC00;
        background-color: #0000FF;
            font-weight: 700;
        }
        .style8
        {
            font-size: large;
            font-family: "Comic Sans MS";
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p class="style7">
        &nbsp;</p>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                <span class="style8"><strong>Catagory : </strong></span>&nbsp;<asp:DropDownList 
                    ID="DdlCat" runat="server" AutoPostBack="True" Height="16px" Width="105px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                <span class="style8"><strong>City : </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DdlCity" runat="server" AutoPostBack="True" Height="16px" 
                    Width="105px">
                    <asp:ListItem>Kolkata</asp:ListItem>
                    <asp:ListItem>New Delhi</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                <span class="style8"><strong>Title :&nbsp; </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txttitle" runat="server" Width="285px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                <strong><span class="style8">Body :</span></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txtbody" runat="server" Height="199px" TextMode="MultiLine" 
                    Width="376px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                <span class="style8"><strong>Picture :&nbsp; </strong></span>&nbsp;&nbsp;
                <asp:FileUpload ID="FilePic" runat="server" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFCCFF; background-repeat: repeat">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p style="height: 25px; background-color: #0000FF">
    </p>
    <p>
        <asp:Button ID="Btnnewssv" runat="server" Text="NEWS SAVE" Width="116px" 
            BackColor="#33CC33" BorderStyle="Solid" CssClass="style6" Font-Bold="True" 
            Font-Size="Medium" ForeColor="#CC0000" onclick="Btnnewssv_Click" />
        <span class="style6">&nbsp;
        </span>
    </p>
    </asp:Content>

