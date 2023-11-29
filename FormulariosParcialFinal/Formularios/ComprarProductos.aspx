<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComprarProductos.aspx.cs" Inherits="FormulariosParcialFinal.Formularios.ComprarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    Comprar Productos</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="ID CLIENTE:"></asp:Label>
&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="IDCLIENTE" DataValueField="IDCLIENTE">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DesarrolloWebParcialConnectionString %>" SelectCommand="SELECT [IDCLIENTE] FROM [CLIENTE]"></asp:SqlDataSource>
</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="ID PRODUCTO:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="IDPRODUCTO" DataValueField="IDPRODUCTO">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DesarrolloWebParcialConnectionString %>" SelectCommand="SELECT [IDPRODUCTO] FROM [PRODUCTO]"></asp:SqlDataSource>
</p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Catidad:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Comprar" />
</p>
    <p>
        <asp:Label ID="Label4" runat="server"></asp:Label>
</p>
    <p>
        &nbsp;</p>
<p>
</p>
</asp:Content>
