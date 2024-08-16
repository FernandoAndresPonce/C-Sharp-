<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejempl02.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:Button ID="btnButton" runat="server" OnClick="btnButton_Click" Text="Aceptar"  />
    <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
   
    
    <a href="About">Vamos a About</a> <%-- Para Navegar entre paginas--%>


</asp:Content>
