<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargarNotas.aspx.cs" Inherits="UI.Web.CargarNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Elija un curso"></asp:Label>
    <asp:DropDownList ID="ddlCursos" runat="server"></asp:DropDownList>
    <br />
    <asp:GridView ID="gvAlumnos" runat="server" Visible="False"></asp:GridView>
</asp:Content>