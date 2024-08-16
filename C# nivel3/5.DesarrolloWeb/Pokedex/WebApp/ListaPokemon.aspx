<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="WebApp.ListaPokemon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="tituloListPokemon">Lista de Pokemon</h1>

  
    <div class="tablaPokemon">
        <asp:GridView ID="dgvPokedex" runat="server" CssClass="table " AutoGenerateColumns="false"
            OnSelectedIndexChanged="dgvPokedex_SelectedIndexChanged" DataKeyNames="Id"
           OnPageIndexChanging ="dgvPokedex_PageIndexChanging" AllowPaging="true" PageSize="5" >
         
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

</asp:Content>
