<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvidarContraseña.aspx.cs" Inherits="UI.Web.OlvidarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar Contraseña</title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
        <asp:Label ID="lblRecuperar" runat="server" Text="Recuperar Contraseña"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="usuarioRequerido" runat="server" ErrorMessage="El usuario no puede estar vacío" ControlToValidate="txtUsuario" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">
        <asp:Label ID="lblClaveAnterior" runat="server" Text="Clave Anterior"></asp:Label>
                </td>
                <td class="auto-style1">
        <asp:TextBox ID="txtClaveAnterior" runat="server" TextMode="Password" style="height: 22px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="claveAnteriorRequerida" runat="server" ErrorMessage="La clave anterior no puede estar vacía" ControlToValidate="txtClaveAnterior" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblClaveNueva" runat="server" Text="Clave Nueva"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNuevaContraseña" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="nuevaContraRequerida" runat="server" ErrorMessage="La nueva contraseña no puede estar vacía" ControlToValidate="txtNuevaContraseña" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"/>
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                </td>
            </tr>
                    </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
