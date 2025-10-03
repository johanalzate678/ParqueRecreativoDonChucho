<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="CapaPresentacion.Juego" %>

<asp:Content  ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="inicio-container"> </div>
         
        <h2>Gestión de Juegos</h2>
    <hr />

    <!-- Formulario de Registro -->
    <div class="formulario">
        <h3>Registrar Nuevo Juego</h3>
        <asp:Label Text="Código del Juego:"  runat="server" />
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox> 

        <asp:Label Text="Nombre del Juego:"  runat="server" />
       <asp:TextBox ID="txtNom" runat="server"></asp:TextBox> 

        <asp:Label Text="Duración (minutos):"  runat="server" />
        <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>

        <asp:Label Text="Categoría:"  runat="server" />
        <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
            <asp:ListItem Text="Seleccione una categoría" Value="" />
            <asp:ListItem Text="Infantil" Value="Infantil" />
            <asp:ListItem Text="Familiar" Value="Familiar" />
            <asp:ListItem Text="Extremo" Value="Extremo" />
        </asp:DropDownList>

        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Juego" OnClick="btnRegistrar_Click" />
    </div>

    <hr />

    <!-- Buscar Juegos -->
    <div class="formulario">
        <h3>Buscar Juego</h3>
        <asp:Label Text="Ingrese Código de Juego:"  runat="server" />
        <asp:TextBox ID="txtBuscarCodigo" runat="server"  />
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />

         <asp:GridView ID="dgvBuscarj" runat="server"></asp:GridView>
        
    </div>
   
    <hr />

    <!-- Listado de Juegos -->
    <div class="tabla">
        <h3>Listado de Juegos</h3>
        <asp:GridView ID="gvJuegos" runat="server" AutoGenerateColumns="False" CssClass="table" GridLines="None" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="CodigoJuego" HeaderText="Código" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Duracion" HeaderText="Duración (min)" />
                <asp:BoundField DataField="Categoria" HeaderText="Categoría" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnListar" runat="server" Text="Listar Todos" OnClick="btnListar_Click"  />
    </div>

         
         
        
       
         

 </asp:Content>
