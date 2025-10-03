<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Atraccion.aspx.cs" Inherits="CapaPresentacion.Atraccion" %>

<asp:Content  ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="inicio-container"> </div>
          <h2>🎢 Gestión de Atracciones</h2>
    <hr />

    <!-- Formulario de Registro -->
    <div class="formulario">
        <h3>Registrar Nueva Atracción</h3>

        <asp:Label Text="Código de la Atraccion:"  runat="server" />
        <asp:TextBox ID="txtCodigoAtraccion" runat="server"></asp:TextBox> <br />

        <asp:Label Text="Nombre de la Atracción"  runat="server" />
        <asp:TextBox ID="txtNombreAtraccion" runat="server"></asp:TextBox> <br />

        <asp:Label Text="Precio Entrada"  runat="server" />
        <asp:TextBox ID="txtPrecioEntrada" runat="server"></asp:TextBox> <br />
        
        <asp:Label Text="Capacidad Maxima"  runat="server" />
        <asp:TextBox ID="txtCapacidadMaxima" runat="server"></asp:TextBox> <br />
        

        

        <br />
        <asp:Button ID="btnRegistrarAtraccion" runat="server" Text="Registrar Atracción" OnClick="btnRegistrarAtraccion_Click"  />
    </div>

    <hr />

    <!-- Formulario de Actualización -->
    <div class="formulario">
        <h3>Actualizar Atracción</h3>

        <asp:Label Text="Código de Atracción (a modificar):" AssociatedControlID="txtCodigoActualizar" runat="server" />
        <asp:TextBox ID="txtCodigoActualizar" runat="server" CssClass="form-control" />

        <asp:Label Text="Nuevo Nombre:" AssociatedControlID="txtNuevoNombre" runat="server" />
        <asp:TextBox ID="txtNuevoNombre" runat="server" CssClass="form-control" />

        <asp:Label Text="Nuevo Precio de Entrada:" AssociatedControlID="txtNuevoPrecio" runat="server" />
        <asp:TextBox ID="txtNuevoPrecio" runat="server" CssClass="form-control" />

        <asp:Label Text="Nueva Capacidad Máxima:" AssociatedControlID="txtNuevaCapacidad" runat="server" />
        <asp:TextBox ID="txtNuevaCapacidad" runat="server" CssClass="form-control" />

        <br />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Atracción" OnClick="btnActualizar_Click"  />
    </div>

    <hr />

    <!-- Buscar Atracción -->
    <div class="formulario">
        <h3>Buscar Atracción</h3>
        <asp:Label Text="Ingrese Código de Atracción:" AssociatedControlID="txtBuscarAtraccion" runat="server" />
        <asp:TextBox ID="txtBuscarAtraccion" runat="server" CssClass="form-control" />
        <asp:GridView ID="dgvBuscarAtraccion" runat="server" AutoGenerateColumns="False" CssClass="table" GridLines="None" CellPadding="10">
    <Columns>
        <asp:BoundField DataField="CodigoAtraccion" HeaderText="Código" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="PrecioEntrada" HeaderText="Precio Entrada" />
        <asp:BoundField DataField="CapacidadMaxima" HeaderText="Capacidad Máxima" />
    </Columns>
</asp:GridView>
        <br />
        <asp:Button ID="btnBuscarAtraccion" runat="server" Text="Buscar" OnClick="btnBuscarAtraccion_Click1"  />
    </div>

    <hr />

    <!-- Listar Atracciones -->
    <div class="tabla">
        <h3>Listado de Atracciones</h3>
        <asp:GridView ID="gvAtracciones" runat="server" AutoGenerateColumns="False" CssClass="table" GridLines="None" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="CodigoAtraccion" HeaderText="Código" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="PrecioEntrada" HeaderText="Precio Entrada" />
                <asp:BoundField DataField="CapacidadMaxima" HeaderText="Capacidad Máxima" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnListarAtracciones" runat="server" Text="Listar Todas" OnClick="btnListarAtracciones_Click"  />
    </div>

        
 </asp:Content>