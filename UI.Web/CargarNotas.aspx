<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargarNotas.aspx.cs" Inherits="UI.Web.CargarNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Elija un curso"></asp:Label>
    <asp:DropDownList ID="ddlCursos" runat="server" AutoPostBack="True"></asp:DropDownList>
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    <br />
    <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="false" SelectedRowStyle-BackColor ="Black" SelectedRowStyle-ForeColor="White"
                DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CssClass="tablaABM">
                <Columns>
                    <asp:BoundField HeaderText="ID Alumno" DataField="IdAlumno" HeaderStyle-CssClass="tablaColumna"/>
                    <asp:BoundField HeaderText ="Condicion" DataField="Condicion" HeaderStyle-CssClass="tablaColumna"/>
                    <asp:BoundField HeaderText="Nota" DataField="Nota" HeaderStyle-CssClass="tablaColumna"/>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" HeaderStyle-CssClass="tablaColumna"/>
                </Columns>
        </asp:GridView>
    <br />
    <asp:Panel ID="panelDatos" runat="server" Visible="False">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre y Apellido"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Condicion"></asp:Label>
    <asp:DropDownList ID="ddlCondicion" runat="server">
        <asp:ListItem>Regular</asp:ListItem>
        <asp:ListItem>Aprobado</asp:ListItem>
        <asp:ListItem>Inscripto</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nota"></asp:Label>
    <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NotaRequerida" runat="server" ErrorMessage="La nota no puede ser vacía" ControlToValidate="txtNota" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>
</asp:Content>