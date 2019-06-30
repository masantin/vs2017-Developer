<%@ Page Title="Administraciónde de Track" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TrackEdit.aspx.cs" Inherits="App.UI.WebForm.Pages.Mantenimiento.Track.TrackEdit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMain" runat="server">

<form runat="server">
    <asp:ValidationSummary 
        ID="ValidationSummary1" 
        runat="server" 
        DisplayMode="BulletList"
    >
    </asp:ValidationSummary>

    <table class="w-100">
    <tr>        
        <td>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                runat="server" ErrorMessage="El campo Nombre es requerido"
                ControlToValidate="txtNombre"
                >*
            </asp:RequiredFieldValidator>
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

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ErrorMessage="El campo Compositor es requerido"
                ControlToValidate="txtCompositor">
            </asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Duración:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>

             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ErrorMessage="El campo Duración es requerido"
                ControlToValidate="txtDuracion"
                Display="Dynamic"
             >
            </asp:RequiredFieldValidator>

            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ErrorMessage="La duración de la canción debe estar entre 1 a 10 min"
                ControlToValidate="txtDuracion"
                MinimumValue="1" MaximumValue="10"
                Type="Integer"
                Display="Dynamic"
                ></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label8" runat="server" Text="Peso:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                ErrorMessage="El campo Peso es requerido"
                ControlToValidate="txtPeso"
                Display="Dynamic"
             >
            </asp:RequiredFieldValidator>

            <asp:RangeValidator ID="RangeValidator2" runat="server" 
                ErrorMessage="La peso de la canción debe estar entre 1MB a 10MB"
                ControlToValidate="txtPeso"
                MinimumValue="1" MaximumValue="10"
                Type="Integer"
                Display="Dynamic"
                ></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label9" runat="server" Text="Precio:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ErrorMessage="El campo Precio es requerido"
                ControlToValidate="txtPrecio"
                Display="Dynamic"
             >
            </asp:RequiredFieldValidator>

            <asp:RangeValidator ID="RangeValidator3" runat="server" 
                ErrorMessage="La precio de la canción debe estar entre 1 a 100 PEN"
                ControlToValidate="txtPrecio"
                MinimumValue="1" MaximumValue="100"
                Type="Double"
                Display="Dynamic"
                ></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="83px" OnClick="btnGuardar_Click"
            CausesValidation="true"    
            />
        </td>
    </tr>
</table>
</form>    



</asp:Content>
