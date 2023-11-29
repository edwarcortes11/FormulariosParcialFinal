<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormulariosParcialFinal.Formularios.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    Ingreso</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server"></asp:Label>
</p>
<p>
</p>
</asp:Content>
