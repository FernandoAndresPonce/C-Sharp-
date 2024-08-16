<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <%-- con auto postback true, logramos no generar un evento dependiende de otro--%>
    <asp:TextBox ID="txtNombre" runat="server" AutoPostBack ="true" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
    <asp:Button ID="btnButton" runat="server" OnClick="btnButton_Click" Text="Agregar" />
    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
    <br /><%-- enter en html--%>
    <asp:Label Text="" ID="lblSecundario" runat="server" />

</asp:Content>
