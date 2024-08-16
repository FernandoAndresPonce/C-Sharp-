<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormPokemon.aspx.cs" Inherits="WebApp.FormPokemon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div>
        <ul>
            <li class="formularioPokemon sinPuntos" style="margin-top: 50px">
                <label for="txtId" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="txtId" placeholder="example Id = 2" CssClass="form-control" />
            </li>
            <li class="formularioPokemon">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </li>
            <li class="formularioPokemon">
                <label for="txtNumero" class="form-label">Numero</label>
                <asp:TextBox runat="server" ID="txtNumero" CssClass="form-control" />
            </li>
            <%--[1.DropDownList hacia DB]--%>
            <li class="formularioPokemon">
                <label for="ddlTipo" class="form-label">Tipo</label>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-select"></asp:DropDownList>
            </li>
            <li class="formularioPokemon">
                <label for="ddlDebilidad" class="form-label">Debilidad</label>
                <asp:DropDownList ID="ddlDebilidad" CssClass="form-select" runat="server" placeholder="Seleccionar"></asp:DropDownList>
            </li>
            <li class="formularioPokemon">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" />
            </li>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <li class="formularioPokemon">
                        <label for="txtUrlImagen" class="form-label">Url Imagen</label>
                        <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="form-control" OnTextChanged="txtUrlImagen_TextChanged" AutoPostBack="true" />
                    </li>

                    <li class="formularioPokemonButtonImangen">
                        <asp:Image ImageUrl="https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=" ID="imgUrlImagen" CssClass="imagenFormPokemon" runat="server" />
                    </li>
                </ContentTemplate>
            </asp:UpdatePanel>
            <li class="formularioPokemonButton">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <asp:Button Text="Cancelar" ID="btnCancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" runat="server" />
                <%--  [6.Eliminar Pokemon]--%>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <br />
                        <%--  [1.Eliminar Pokemon]--%>
                        <asp:Button Text="Eliminar" ID="btnEliminar" CssClass="btn btn-danger " OnClick="btnEliminar_Click" runat="server" />
                        </li>
                        <%--  [2.Eliminar Pokemon]--%>
                        <%--  [5.Eliminar Pokemon]--%>

                        <%if (ConfirmaEliminacion)
                            { %>
                        <li>
                            <asp:CheckBox Text="Confirmar Eliminacion" ID="ckConfirmaEliminacion" runat="server" />
                            <asp:Button Text="Confirmar" ID="btnConfirmar" CssClass="btn btn-outline-danger" OnClick ="btnConfirmar_Click" runat="server" />
                        </li>
                        <%}%>
                    </ContentTemplate>
                </asp:UpdatePanel>
        </ul>
    </div>




    <%--ejemplo de dropdownlist.--%>
    <asp:DropDownList runat="server">
        <asp:ListItem Text="Rojo" />
        <asp:ListItem Text="Verde" />
    </asp:DropDownList>






</asp:Content>
