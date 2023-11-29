<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarContrasena.aspx.cs" Inherits="FormulariosParcialFinal.Formularios.ActualizarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        Actualizar Contraseña</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="ID:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Nombres:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Apellidos:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Dirección:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Telefono:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Usuario:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Contraseña:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Actualizar Contraseña" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
