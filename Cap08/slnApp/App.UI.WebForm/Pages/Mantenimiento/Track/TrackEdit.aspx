<%@ Page Title="Administraciónde de Track" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrackEdit.aspx.cs" Inherits="App.UI.WebForm.Pages.Mantenimiento.Track.TrackEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        </td>
        <td>
            &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 26px">
            <asp:Label ID="Label2" runat="server" Text="Album:"></asp:Label>
        </td>
        <td style="height: 26px">
            <asp:DropDownList ID="ddlAlbum" runat="server" Height="20px" Width="101px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="height: 29px">
            <asp:Label ID="Label4" runat="server" Text="Media:"></asp:Label>
        </td>
        <td style="height: 29px">
            <asp:DropDownList ID="ddlMedia" runat="server" Height="20px" Width="101px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Género:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlGenero" runat="server" Height="20px" Width="100px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Compositor:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCompositor" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Duración:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label8" runat="server" Text="Peso:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label9" runat="server" Text="Precio:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="83px" OnClick="btnGuardar_Click" />
        </td>
    </tr>
</table>
</asp:Content>
