<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col">

            <%--    Puedo agregaar una propiedad para sacar columnas de la grilla, este
    autoGenerateColumns me da la posibilidad en false en cambiar la columna.--%>
            <asp:GridView ID="dgvAutos" runat="server" CssClass="table table-dark" AutoGenerateColumns="false">
                <Columns>
                    <%-- por la dudas, hay que poner data antes del BOundField para que aparezca....
                en el DataField siempre va el nombre de la propiedad de la clase.--%>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:BoundField HeaderText="Importado" DataField="Importado" />
                </Columns>
            </asp:GridView>
            <a href="AutoForm">Agregar</a>
        </div>
    </div>

</asp:Content>
