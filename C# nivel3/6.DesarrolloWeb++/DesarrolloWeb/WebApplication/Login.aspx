<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label Text="User" for="txtUser" runat="server" />
        <asp:TextBox runat="server" placeholder="User name" CssClass="form-control" ID="txtUser"/>
    </div>
       <div>
        <asp:Label Text="Password" for="txtPassword" runat="server" />
        <asp:TextBox runat="server" placeholder="Password" CssClass="form-control" ID="txtPassword" TextMode="Password"/>
    </div>
    <div>
        <asp:Button Text="Ingresar" OnClick="btnIngresar_Click" ID="btnIngresar" CssClass="btn btn-primary" runat="server" />
    </div>

</asp:Content>
