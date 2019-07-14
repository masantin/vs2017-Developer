<%@ Page Title="Administraciónde de Track" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TrackEdit.aspx.cs" Inherits="App.UI.WebForm.Pages.Mantenimiento.Track.TrackEdit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMain" runat="server">

    <div class="form-horizontal">

        <asp:HiddenField ID="hdfCodigo" runat="server" />

        <div class="box box-primary">
            <div class="box-body">
                <div class="form-group">
                    <label class="col-sm-2 control-label">Nombre</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server"
                            Display="Dynamic"
                            ErrorMessage="El campo Nombre es requerido"
                            ControlToValidate="txtNombre">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Album</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlAlbum" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Media</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlMedia" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Género</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlGenero" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Compositor</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtCompositor" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ErrorMessage="El campo Compositor es requerido"
                            ControlToValidate="txtCompositor"
                            Display="Dynamic">                                
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Duración</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtDuracion" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ErrorMessage="El campo Duración es requerido"
                            ControlToValidate="txtDuracion"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server"
                            ErrorMessage="La duración de la canción debe estar entre 1 a 10 min"
                            ControlToValidate="txtDuracion"
                            MinimumValue="1" MaximumValue="10"
                            Type="Integer"
                            Display="Dynamic"></asp:RangeValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Peso</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtPeso" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ErrorMessage="El campo Peso es requerido"
                            ControlToValidate="txtPeso"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server"
                            ErrorMessage="La peso de la canción debe estar entre 1MB a 10MB"
                            ControlToValidate="txtPeso"
                            MinimumValue="1" MaximumValue="10"
                            Type="Integer"
                            Display="Dynamic"></asp:RangeValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Precio</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                            ErrorMessage="El campo Precio es requerido"
                            ControlToValidate="txtPrecio"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>

                        <asp:RangeValidator ID="RangeValidator3" runat="server"
                            ErrorMessage="La precio de la canción debe estar entre 1 a 100 PEN"
                            ControlToValidate="txtPrecio"
                            MinimumValue="1" MaximumValue="100"
                            Type="Double"
                            Display="Dynamic"></asp:RangeValidator>
                    </div>
                </div>
            </div>
            <div class="box-footer">

                <asp:Button ID="btnGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" Width="83px" OnClick="btnGuardar_Click"
                    CausesValidation="true" />

            </div>
        </div>


    </div>



</asp:Content>
