<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DropDownListEnlazado.aspx.cs" Inherits="WebApp.DropDownListEnlazado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--[1.UpdatePAnel], para uqe no se actualice constantemente , haga ese "Parpadeo"--%>
    <asp:ScriptManager ID="ScripManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
             <%--[2.UpdatePAnel], ponemos lo que esta entre los dos [2.UpdatePAnel]"--%>
            <%--[1.dropdownlist Enlazado]--%>
            <div>
                <ul>
                    <%--[2.dropdownlist Enlazado]--%>
                    <%--el autopostback en true lo necesitamos, para cuando seleccione carge y vaya al servidor, 
                haga una peticion, como por  ejemplo como cuando tenemos un boton y tocamos click.--%>

                    <li class="formularioPokemon">
                        <label for="ddlTipo" class="form-label">Tipo</label>
                        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-select" AutoPostBack="true"
                            OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
                        </asp:DropDownList>
                    </li>
                    <li class="formularioPokemon">
                        <label for="ddlPokemonEnlazadoTipo" class="form-label">Pokemon</label>
                        <asp:DropDownList ID="ddlPokemonEnlazadoTipo" runat="server" CssClass="form-select"></asp:DropDownList>
                    </li>
                </ul>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
