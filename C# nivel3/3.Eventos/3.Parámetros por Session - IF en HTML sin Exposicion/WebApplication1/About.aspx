<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--    Mostrar un titulo o otro depedniendo lo que hagamos.--%>

    <%if (user != "")
        { %>
    <h2>Ingresaste.</h2>
    <asp:Label Text="" ID="lblNombre" runat="server" />
    <%}
        else
        {%>

    <h2>Debes loguearte.</h2>
    <br />
    <a href="Default">Regresar</a>
    <%} %>
</asp:Content>
