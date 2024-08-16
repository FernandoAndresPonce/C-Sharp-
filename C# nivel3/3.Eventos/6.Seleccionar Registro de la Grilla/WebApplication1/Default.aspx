<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--PASO 3 AHORA OBTENER ID--%>
<%--    <style>
        .oculto{
            display:none;
        }
    </style>--%>

    <div class="row">
        <div class="col">

            <%--    Puedo agregaar una propiedad para sacar columnas de la grilla, este
    autoGenerateColumns me da la posibilidad en false en cambiar la columna.--%>
            <asp:GridView ID="dgvAutos" runat="server" DataKeyNames="Id" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged" CssClass="table table-dark" AutoGenerateColumns="false">
                <Columns>
                <%--PASO 4 PARA OBTENER EL ID, Y OCULTANDOLO, O OTRA MANERA AGREGANDO ELD DATAKEYNAMES QUE SERIA COMO DATA FIELD--%>

                    <%--<asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />--%>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:BoundField HeaderText="Importado" DataField="Importado" />
                    <%--PASO 1--%>
                    <%--nos permite seleccionar una fila, si es que queremos acceder a una fila determinada--%>
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />

                  
                </Columns>
            </asp:GridView>
            <a href="AutoForm">Agregar</a>
        </div>
    </div>

</asp:Content>
