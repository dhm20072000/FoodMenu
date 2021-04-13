<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FoodMenu.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <h1>Here is a list of your order!</h1>
        Please review it before checkout.
    </div>
    <br />
    <br />
    <asp:TextBox ID="txtCart" runat="server" CssClass="space" Height="400px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    
    <br />
    <br />
  
    <div class="space1">
        Total:  <asp:Label ID="lblTotal" runat="server" Font-Bold="True"></asp:Label>
    </div>
    <br />
    <asp:Button ID="btnClear" runat="server" CssClass="space2" OnClick="btnClear_Click" Text="Clear" />
    <br />
    <br />
    <asp:Label ID="lblClear" runat="server" CssClass="space1" ForeColor="Green"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
</asp:Content>
