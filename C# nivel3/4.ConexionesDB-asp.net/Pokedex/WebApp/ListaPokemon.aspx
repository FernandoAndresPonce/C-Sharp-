<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="WebApp.ListaPokemon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista de Pokemon</h1>

   <%-- 5. [Listar con Stored ProcedurePágina]--%>
    <asp:GridView ID="dgvPokedex" runat="server" CssClass="table" AutoGenerateColumns="false" >
         <Columns>
             <asp:BoundField HeaderText="Numero" DataField="Numero" />
             <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
             <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
             <asp:BoundField HeaderText="Debilidad" DataField="Debilidad.Descripcion" />
             <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
         </Columns>

    </asp:GridView>

</asp:Content>
