﻿<%@ Page Title="Personas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColums="false"
            SelectedRowsStyle-BackColor ="Black"
            SelectedRowsStyle-ForeColor="White"
            DataKeyName="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                <asp:CommnadFiel SelectText = "Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText ="Apellido" DataField="Apellido"/>
                <asp:CommandFiel SelectText ="Seleccionar" ShowSelecteButton="true"/>
                <asp:BoundField HeaderText="Direccion" DataField="Direccion"/>
                <asp:CommandField SelectedText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText="Email" DataField="Email"/>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento"/>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText="Legajo" DataField="Legajo"/>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText="TipoPersona" DataField="TipoPersona" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
                <asp:BoundField HeaderText ="IDPlan" DataField="IDPlan"/>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="nombreRequerido" runat="server" ErrorMessage="El nombre no puede estar vacio" ControlToValidate="nombreTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="apellidoRequerido" runat="server" ErrorMessage="El apellido no puede estar vacío" ControlToValidate="apellidoTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="Dirección:"></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="direccionRequerida" runat="server" ErrorMessage="La dirección no puede estar vacía" ControlToValidate="direccionTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Teléfono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="fechaNacimientoLabel" runat="server" Text="Fecha Nacimiento: "></asp:Label>
        <asp:TextBox ID="fechaNacimientoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="fechaNacimientoRequerida" runat="server" ErrorMessage="La fecha de nacimiento no puede estar vacía" ControlToValidate="fechaNacimientoTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="legajoRequerido" runat="server" ErrorMessage="El legajo no puede estar vacío" ControlToValidate="legajoTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
         <asp:Label ID="tipoPersonaLabel" runat="server" Text="Tipo de persona: "></asp:Label>
        <asp:TextBox ID="tipoPersonaTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="tipoPesonaRequerido" runat="server" ErrorMessage="El tipo de persona no puede estar vacío" ControlToValidate="tipoPersonaTextBox" ForeColor = "Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="IDPlanLabel" runat="server" Text="ID Plan: "></asp:Label>
    </asp:Panel>
    <asp:Panel ID ="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
