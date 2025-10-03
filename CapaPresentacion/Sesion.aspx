<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="CapaPresentacion.Sesion" %>

<asp:Content  ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="inicio-container"> </div>
        <h2>🎮 Registro de Sesiones de Juego</h2>
    <hr />

    <!-- Formulario de Registro -->
    <div class="formulario">
        <h3>Registrar Nueva Sesión</h3>

        <asp:Label Text="Código de Atracción:" AssociatedControlID="txtCodigoAtraccion" runat="server" />
        <asp:TextBox ID="txtCodigoAtraccion" runat="server" CssClass="form-control" />

        <asp:Label Text="Código de Juego:" AssociatedControlID="txtCodigoJuego" runat="server" />
        <asp:TextBox ID="txtCodigoJuego" runat="server" CssClass="form-control" />

        <asp:Label Text="Número de Zona:" AssociatedControlID="txtNumeroZona" runat="server" />
        <asp:TextBox ID="txtNumeroZona" runat="server" CssClass="form-control" />

        <asp:Label Text="Hora de Inicio:" AssociatedControlID="txtHoraInicio" runat="server" />
        <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" TextMode="DateTime" />

        <asp:Label Text="Cantidad de Boletos Vendidos:" AssociatedControlID="txtBoletos" runat="server" />
        <asp:TextBox ID="txtBoletos" runat="server" CssClass="form-control" />

        <br />
        <asp:Button ID="btnRegistrarS" runat="server" Text="Registrar Sesión" OnClick="btnRegistrarS_Click"  />
    </div>

    <hr />

    <!-- Listado de Sesiones -->
    <div class="tabla">
        <h3>Listado de Sesiones</h3>
        <asp:GridView ID="gvSesiones" runat="server" AutoGenerateColumns="False" CssClass="table" GridLines="None" CellPadding="10">
            <Columns>
                
                <asp:BoundField DataField="CodigoAtraccion" HeaderText="Código Atracción" />
                <asp:BoundField DataField="CodigoJuego" HeaderText="Código Juego" />
                <asp:BoundField DataField="NumeroZona" HeaderText="Zona" />
                <asp:BoundField DataField="HoraInicio" HeaderText="Hora Inicio" />
                <asp:BoundField DataField="BoletosVendidos" HeaderText="Boletos Vendidos" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnListarS" runat="server" Text="Listar Sesiones" OnClick="btnListarS_Click" />
    </div>

         
         
        
       
         

 </asp:Content>