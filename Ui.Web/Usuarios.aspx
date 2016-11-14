<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField HeaderText="nombre" DataField="nombre" SortExpression="nombre" />
                <asp:BoundField HeaderText="apellido" DataField="apellido" SortExpression="apellido" />
                <asp:BoundField HeaderText="email" DataField="email" SortExpression="email" />
                <asp:BoundField HeaderText="nombre_usuario" DataField="nombre_usuario" SortExpression="nombre_usuario" />
                <asp:CheckBoxField DataField="habilitado" HeaderText="habilitado" SortExpression="habilitado" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=LAPTOP-SQQRFPKK\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [nombre], [apellido], [email], [nombre_usuario], [habilitado] FROM [usuarios] ORDER BY [nombre]"></asp:SqlDataSource>
    </asp:Panel>
<asp:Panel ID="Usuarios" Visible="false" runat="server">
    <asp:Label ID="nombreLabel" runat="server" Text="Nombre: ">  </asp:Label>
    <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: ">  </asp:Label>
    <asp:TextBox ID="ApellidoTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="emailLabel" runat="server" Text="Email: ">  </asp:Label>
    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: ">  </asp:Label>
    <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
    <br />
    <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: ">  </asp:Label>
    <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="claveLabel" runat="server" Text="Clave: ">  </asp:Label>
    <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: ">  </asp:Label>
    <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
</asp:Panel>

<asp:Panel ID="gridActionsPanel" runat="server">
    <asp:LinkButton ID="editarLinkButton" runat="server"> Editar </asp:LinkButton>
    <asp:LinkButton ID="eliminarLinkButton" runat="server"> Eliminar </asp:LinkButton>
    <asp:LinkButton ID="nuevoLinkButton" runat="server"> Nuevo </asp:LinkButton>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Panel>

<asp:Panel ID="formActionsPanel" runat="server">
    <asp:LinkButton ID="aceptarLinkButton" runat="server"> Aceptar </asp:LinkButton>
    <asp:LinkButton ID="cancelarLinkButton" runat="server"> Cancelar </asp:LinkButton>
</asp:Panel>
</asp:Content>