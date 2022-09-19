<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="UI.Web.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>login</title>
    <link href="Styles/login_s.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src="Styles/wood-panel-5728430_960_720.jpg" class="panel" />
        </section>
        <div class="sec2">
            <div class="container">
                <div class="social">
                    <asp:HyperLink ID="HyperLink1" runat="server">¿Olvidaste tu clave?</asp:HyperLink>
                </div>

                <div class="content">
                    <h2>Sign Up</h2>

                    <asp:TextBox ID="txtUsuario" placeholder="Usuario" runat="server"></asp:TextBox><br />
                    <asp:TextBox ID="txtClave" placeholder="Clave" runat="server"></asp:TextBox><br />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>
