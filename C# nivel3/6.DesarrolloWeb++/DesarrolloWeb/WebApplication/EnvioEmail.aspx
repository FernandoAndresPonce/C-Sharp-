<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSite.Master" AutoEventWireup="true" CodeBehind="EnvioEmail.aspx.cs" Inherits="WebApplication.EnvioEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--[1.Envío de emails]--%>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Email" for="txtEmail" runat="server" />
                <asp:TextBox runat="server" placeholder="ejemplo@ejemplo.com" CssClass="form-control" ID="txtEmail" TextMode="Email" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Asunto" for="txtAsunto" runat="server" />
                <asp:TextBox runat="server" CssClass="form-control" ID="txtAsunto" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Mensaje" for="txtMensaje" runat="server" />
                <asp:TextBox runat="server" placeholder="Deje su mensaje" CssClass="form-control" ID="txtMensaje" TextMode="MultiLine" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Button Text="Enviar" ID="bntEnviar" CssClass="btn btn-primary" OnClick="bntEnviar_Click" runat="server" />
            </div>
        </div>
    </div>

</asp:Content>
