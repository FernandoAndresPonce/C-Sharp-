<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="WebApplication1.AutoForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--            public int Id { get; set; }
            public string Modelo { get; set; }
            public string Descripcion { get; set; }
            public string Color { get; set; }
            public DateTime Fecha { get; set; }
            public bool Usado { get; set; }
            public bool Importado { get; set; }--%>


    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" placeholder="ingrese algo"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <%--       el textMode multilinea , permite que un textBox escriba mas de una linea hacia abajo--%>
                <label for="txxtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="mb-3">
                <label for="ddlColores" class="form-label">Color</label>
                <asp:DropDownList ID="drop" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>


            <div class="mb-3">
                <%--       el textMode DATE , permite que un textBoxo , nos permite que aparezca la FECHA.--%>
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox Text="" ID="cbUsado" runat="server" />
                <asp:Label Text="Usado" CssClass="form-check-label" runat="server" />
            </div>
            <div class="mb-3">
                <%--para unir los radioBUtton en un grupo y se pueda seleccionar uno solo de los mismo, armamos un grupo.--%>
                <asp:RadioButton ID="rbImportado" AutoPostBack="true" OnCheckedChanged="rbImportado_CheckedChanged" Text="Importados" runat="server" GroupName="Importado" />

                <%--el checked true es que empieza con ese seleccionado.--%>
                <asp:RadioButton ID="rbNacional" AutoPostBack="true"  OnCheckedChanged="rbImportado_CheckedChanged" Text="Nacionales" runat="server" Checked="true" GroupName="Importado" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>


        </div>
    </div>

</asp:Content>
