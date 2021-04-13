<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FoodMenu.aspx.cs" Inherits="FoodMenu.FoodMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <h1>Welcome to our restaurant!</h1>
        Please check out our menu items below to order.
    </div>


<asp:SqlDataSource ID="SqlDataSourceCategory" runat="server" ConnectionString="<%$ ConnectionStrings:c432020fa02dangmConnectionString %>" SelectCommand="SELECT DISTINCT category from Menu;"></asp:SqlDataSource>
    <br />
    <br />
    <asp:DropDownList ID="ddlCategory" runat="server" AppendDataBoundItems="True" AutoPostBack="True" CssClass="space" DataSourceID="SqlDataSourceCategory" DataTextField="category" DataValueField="category" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
        <asp:ListItem Text="--Select a category--" Value="" />
    </asp:DropDownList>
    <br />
    <br />
    <div class="space">Pick you favorite food:</div>
    <asp:ListBox ID="lbCategory" runat="server" CssClass="space" Height="200px" Width="350px"></asp:ListBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lbCategory" Display="Dynamic" ErrorMessage="Please pick an item from the menu" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <br />
    <div class="space">Enter quantity:</div>
    <asp:TextBox ID="txtquantity" runat="server" CssClass="space"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtquantity" Display="Dynamic" ErrorMessage="Please enter quantity" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtquantity" Display="Dynamic" ErrorMessage="Enter between 1 and 10" ForeColor="Red" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
    <br />
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" CssClass="space" Text="Add to cart" OnClick="btnSubmit_Click" />
    <br />
    <br />
    <br />
    <asp:Label ID="lblStatus" runat="server" CssClass="space" ForeColor="Green"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    


</asp:Content>
