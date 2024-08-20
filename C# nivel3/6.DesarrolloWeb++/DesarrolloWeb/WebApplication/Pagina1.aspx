<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSite.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="WebApplication.Pagina1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h2>Pudiste entrar ACA porque te logueaste!
        </h2>
    </div>
    <div>
        <asp:Button Text="Regresar" ID="btnRegresar" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" />
    </div>

</asp:Content>
