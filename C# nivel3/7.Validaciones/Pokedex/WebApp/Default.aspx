<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 class="titulo">Bienvenido al Mundo POKEMON </h1>

    <div class="row row-cols-1 row-cols-md-3 g-4" style="margin: 20px">
        <%--1.[ Listar con ForeachPágina ] ACA ES DONDE USAMOS FOREACH, PARA QUE PONGA TANTAS TARJETAS COMO 
            POKEMONES TENGAMOS EN LA BASE DE DATO.--%>
        <%--        <%
            //3.[ Listar con ForeachPágina ]
            foreach (Dominio.Pokemon pokemon in ListaPokemon)
            {

        %>
        <div class="col">
            <div class="card h-100">
                <img src="<%:pokemon.UrlImagen%>" class="card-img-top" alt="<%: pokemon.Nombre %>">
                <div class="card-body">
                    <h5 class="card-title"><%: pokemon.Nombre %></h5>
                    <p class="card-text"><%:pokemon.Descripcion %></p>
                    <a href="DetallePokemon.aspx?id=<%:pokemon.Id %>">Ver Detalle</a>
                </div>
            </div>
        </div>


        <% } %>--%>

        <%--[1.Listar con RepeaterPágina / parecido al FOREACH pero MEJORADO!]--%>
        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>

                <%--[3.Listar con RepeaterPágina]--%>
                <div class="col">
                    <div class="card h-100">
                        <img src="<%# Eval ("UrlImagen")%>" class="card-img-top" alt="<%# Eval("Nombre") %>">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><%# Eval("Descripcion") %></p>
                            <a href="DetallePokemon.aspx?id=<%# Eval("Id")%>">Ver Detalle</a>
                             <%--[4.Listar con RepeaterPágina], con la Accionar el button se lleva un valor como argumento, en este caso el ID--%>
                                                                                            <%--commandArgumento el valor hay que pasarlo con COMILLAS SIMPLES ' VALOR '--%>
                            <asp:Button Text="Ejemplo" ID="btnEjemplo" CssClass="btn btn-primary" runat="server" CommandArgument='<%#Eval("Id")%>' CommandName="PokemonId" OnClick="btnEjemplo_Click"/>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
