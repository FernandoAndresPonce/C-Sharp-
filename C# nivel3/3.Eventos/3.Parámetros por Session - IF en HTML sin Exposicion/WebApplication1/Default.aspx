<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  
    <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
    <asp:TextBox ID="txtContrasena" runat="server" />
    <asp:Button ID="btnButton" runat="server" OnClick="btnButton_Click" Text="Agregar" />
    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
   
    <br /><%-- enter en html--%>
    
    <asp:Label Text="" ID="lblSecundario" runat="server" />

   <%-- // aca tambien puede viajar la url con parametros.--%>
    <a href="About?id=3">Descripcion</a>

</asp:Content>
