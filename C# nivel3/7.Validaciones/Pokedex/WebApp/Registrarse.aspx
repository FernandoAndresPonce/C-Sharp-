<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="WebApp.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <%-- [1.Registro Trainee - output SQL - MailTrap]--%>
    <div>
        <ul>
            <li>
                <h2 class="formularioPokemon">Crea tu Perfil Trainee!</h2>
            </li>
            <li class="formularioPokemon" style="margin-top: 50px">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" placeholder="example@example.com" CssClass="form-control" />
            </li>
            <li class="formularioPokemon">
                <label for="txtPassword" class="form-label">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password" />
            </li>
            <li class="formularioPokemon">
                <asp:Button Text="Registrarse" ID="btnRegistrarse" CssClass="btn btn-primary" OnClick="btnRegistrarse_Click1" runat="server" />
                <a href="/">Cancelar</a>>

            </li>
        </ul>

    </div>
</asp:Content>
