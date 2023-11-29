<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CRUDCliente.aspx.cs" Inherits="FormulariosParcialFinal.Formularios.CRUDCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        Cliente</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click1" />
&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Limpiar" OnClick="Button5_Click" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombres:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Apellidos:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Correo:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Dirección:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Telefono:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Crear" OnClick="Button2_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Actualizar" OnClick="Button3_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label8" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
