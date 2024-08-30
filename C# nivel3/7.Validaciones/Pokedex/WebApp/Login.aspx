<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
 <%--[1.Login]--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <ul>
            <li>
                <h2 class="formularioPokemon">Login!</h2>
            </li>
            <li class="formularioPokemon" style="margin-top: 50px">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" required placeholder="example@example.com" CssClass="form-control" />
            </li>
            <li class="formularioPokemon">
                <label for="txtPassword" class="form-label">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"  TextMode="Password" />
            </li>
            <li class="formularioPokemon">
                <asp:Button Text="Ingresar" ID="btnIngresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" runat="server" />
                <a href="/">Cancelar</a>>

            </li>
        </ul>

    </div>
</asp:Content>
