<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TrackList.aspx.cs" Inherits="App.UI.WebForm.Pages.Mantenimiento.Track.TrackList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
    <script>
        //Aquí está el código javascript de la página TrackList
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">

    <form runat="server">
        <asp:GridView ID="grvListado" runat="server" CssClass="table"
            GridLines="None"
            
            >
        </asp:GridView>
        
        <asp:Button ID="btnBuscar" runat="server"         
        Text="Button" OnClick="btnBuscar_Click"/>
   </form>
   
    
</asp:Content>
