﻿<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
<asp:Panel ID="formPanel" Visible="false" runat="server">
    <asp:Label ID="nombreLabel" runat="server" Text="Nombre: ">  </asp:Label>
    <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: ">  </asp:Label>
    <asp:TextBox ID="ApellidoTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="emailLabel" runat="server" Text="Email: ">  </asp:Label>
    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: ">  </asp:Label>
    <asp:TextBox ID="habilitadoTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: ">  </asp:Label>
    <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="claveLabel" runat="server" Text="Clave: ">  </asp:Label>
    <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: ">  </asp:Label>
    <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"></asp:TextBox>
    <br />
</asp:Panel>

<asp:Panel ID="gridActionsPanel" runat="server">
    <asp:LinkButton ID="editarLinkButton" runat="server"> Editar </asp:LinkButton>
    <asp:LinkButton ID="eliminarLinkButton" runat="server"> Eliminar </asp:LinkButton>
    <asp:LinkButton ID="nuevoLinkButton" runat="server"> Nuevo </asp:LinkButton>
</asp:Panel>

<asp:Panel ID="formActionsPanel" runat="server">
    <asp:LinkButton ID="aceptarLinkButton" runat="server"> Aceptar </asp:LinkButton>
    <asp:LinkButton ID="cancelarLinkButton" runat="server"> Cancelar </asp:LinkButton>
</asp:Panel>
</asp:Content>