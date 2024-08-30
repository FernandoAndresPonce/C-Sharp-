<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="WebApp.ListaPokemon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <h1 class="tituloListPokemon">Lista de Pokemon</h1>



    <%--//[3.Filtro Rapido]--%>
    <div class="formularioPokemon" >
        <asp:TextBox runat="server" AutoPostBack="true" ID="txtFiltro" placeholder="Busqueda rapida..." CssClass="form-control" OnTextChanged="txtFiltro_TextChanged" />
        <br />
         <%--//[2.Filtro Avanzado]--%>
        <label for="cbFiltroAvanzado" class="form-label">Filtro Avanzado</label>
        <asp:CheckBox ID="cbFiltroAvanzado" runat="server" OnCheckedChanged="cbFiltroAvanzado_CheckedChanged" AutoPostBack="true"/>
    </div>

    <%--//[1.Filtro Avanzado]--%>
    <%--en este if tambien podria usar solamente checkbox.cheked , y listo, omitiendo el paso de crear una propiedad.--%>
    <%if (FiltroAvanzado)
        { %>
    <div class="row formularioPokemon">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Campo" ID="txtCampo" runat="server" />

                <%--//[6.Filtro Avanzado]--%>
                <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="Nombre" />
                    <asp:ListItem Text="Tipo" />
                    <asp:ListItem Text="Numero" />
                </asp:DropDownList>
            </div>
        </div>

        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Criterio" runat="server" />
                <asp:DropDownList ID="ddlCriterio" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Filtro" runat="server" />
                <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Estado" runat="server" />
                <asp:DropDownList CssClass="form-control" ID="ddlEstado" runat="server">
                    <asp:ListItem Text="Todos" />
                    <asp:ListItem Text="Activo" />
                    <asp:ListItem Text="Inactivo" />
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row formularioPokemon">
        <div class="col-3">
            <div class="mb-3">
                <%--//[7.Filtro Avanzado]--%>
                <asp:Button Text="Buscar" CssClass="btn btn-primary" ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" />
            </div>
        </div>
    </div>
    <%} %>


    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="tablaPokemon">
                <asp:GridView ID="dgvPokedex" runat="server" CssClass="table " AutoGenerateColumns="false"
                    OnSelectedIndexChanged="dgvPokedex_SelectedIndexChanged" DataKeyNames="Id"
                    OnPageIndexChanging="dgvPokedex_PageIndexChanging" AllowPaging="true" PageSize="5">

                    <Columns>
                        <asp:BoundField HeaderText="Numero" DataField="Numero" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
                        <asp:BoundField HeaderText="Debilidad" DataField="Debilidad.Descripcion" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
                        <asp:CommandField ShowSelectButton="true" HeaderText="Accion" SelectText="Modificar" />
                    </Columns>
                </asp:GridView>
                <asp:Button Text="Agregar" ID="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" runat="server" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
