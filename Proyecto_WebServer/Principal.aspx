﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Proyecto_WebServer.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>PRINCIPAL</title>
    <style type="text/css">
        auto_style1{
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="FPrincipal" runat="server">
        <div>
<<<<<<< HEAD
            <div class="container d-flex justify-content-center">
                <img src="https://cdn.freebiesupply.com/logos/thumbs/2x/mysql-2-logo.png" width="350" />
            </div>
            <div class="d-flex justify-content-center container">
                <h1>LIBRERIA</h1> 
=======
            <div class="auto_style1">
                LIBRERIA 
>>>>>>> e19fb9747fcfb396dbfe0109b384c4448fa72dee
            </div>
            <br />
            <div>
                <asp:GridView ID="dgvLibros" runat="server"></asp:GridView>
            </div>
            <br />
            <div class="auto_style1">
                <asp:Button ID="btnVer" runat="server" Text="Ver Libros" OnClick="btnVer_Click"/>
                <asp:Button ID="btnAnadir" runat="server" Text="Añadir Libro" OnClick="btnAnadir_Click"/>
                <asp:Button ID="btnModificar" runat="server" Text="Modificar Libro" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Libro" OnClick="btnEliminar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
