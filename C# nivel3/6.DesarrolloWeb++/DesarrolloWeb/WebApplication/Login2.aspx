<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSite.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="WebApplication.Login2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Te Logueaste exitosamente</h2>

    <div class="row">
        <div class="col-3">
            <asp:Button Text="Pagina1" ID="btnPagina1" CssClass="btn btn-primary" OnClick="btnPagina1_Click" runat="server" />
        </div>

   <%--     //4.Login y PermisosPágina--%>
        <%if (Session["usuario"] != null && ((dominio.Usuario)Session["usuario"]).TipoUser == dominio.TipoUsuario.ADMIN) {%>
        <div class="col-3">
            <asp:Button Text="Pagina2" ID="btnPagina2" CssClass="btn btn-primary" OnClick="btnPagina2_Click" runat="server" />
            <div class="row">
                <asp:Label Text="Tenes que ser ADM" runat="server" />
            </div>
        </div>
        <%} %>
    </div>




</asp:Content>
