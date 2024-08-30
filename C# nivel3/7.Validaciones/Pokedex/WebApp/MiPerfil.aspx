<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="WebApp.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <style>

        .validacion{
            color: red;
            font-size: 12px;
        }

    </style>

    <div>
        <ul>
            <li class="formularioPokemon sinPuntos" style="margin-top: 50px">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" />
            </li>
            <li class="formularioPokemon">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                <%--<%--validaor de asp.net--%> <%--antes de agregar esta propiedad debemos ir al webConfig--%>
                <asp:RequiredFieldValidator ErrorMessage="El nombre es requerido." CssClass="validacion" ControlToValidate="txtNombre" runat="server" />
            </li>
            <li class="formularioPokemon">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
               <%-- Validators Range y RegEx IMPORTANTE--%>
                <asp:RangeValidator ErrorMessage="Fuera de rango" ControlToValidate="txtApellido" Type="Currency" MinimumValue="1" MaximumValue="20" runat="server" />
                <%--y RegEx expresion regular se refiere en el campo que vamos a escribir que puede recibir solamente.--%>
                <asp:RegularExpressionValidator ErrorMessage="Solo numeros" ControlToValidate="txtApellido" ValidationExpression="^[0-9]+$" runat="server" />

            </li>
            <li class="formularioPokemon">
                <label for="txtFechaNacimiento" class="form-label">Fecha Nacimiento</label>
                <asp:TextBox runat="server" ID="TxtFechaNacimiento" CssClass="form-control" TextMode="Date" />
            </li>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <%--[1.Subir Imagen a Perfil]--%>
                    <li class="formularioPokemon">
                        <label for="txtImagenPerfil" class="form-label">Imagen Perfil</label>
                        <input type="file" ID="txtImagenPerfil"  Class="form-control" runat="server"/>
                    </li>

                    <li class="formularioPokemonButtonImangen">
                        <asp:Image ImageUrl="https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=" ID="imgImagen" CssClass="imagenFormPokemon" runat="server" />
                    </li>
                </ContentTemplate>
            </asp:UpdatePanel>
            <li class="formularioPokemonButton">
                <asp:Button Text="Guardar" ID="btnGuardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" runat="server" />
                <asp:Button Text="Cancelar" ID="btnCancelar" CssClass="btn btn-primary"  runat="server" />
            </li>
        </ul>
    </div>
</asp:Content>
