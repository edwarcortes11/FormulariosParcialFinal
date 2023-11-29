<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaFactura.aspx.cs" Inherits="FormulariosParcialFinal.Formularios.ConsultaFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        Consulta de Facturas</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID Factura:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar Factura" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Limpiar" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="ID Cliente:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="ID Producto:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Cantidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Subtotal:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Iva:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Total:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Enabled="False" Font-Bold="True" ForeColor="Red"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label8" runat="server"></asp:Label>
    </p>
</asp:Content>
