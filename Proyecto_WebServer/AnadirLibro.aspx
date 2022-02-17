<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnadirLibro.aspx.cs" Inherits="Proyecto_WebServer.AnadirLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <title>Añadir libro</title>
    <style type="text/css">
        auto_style1{
            text-align: center;
        }
    </style>          
</head>
<body>
    <div class="wrapper">
        <div class="formcontent">
            <form id="FAnadirLibro" runat="server">
        <div>
            <div class="auto_style1">
                AÑADIR LIBRO
                <hr />
            </div>
            <div class="auto_style1">
                <asp:Label ID="Label1" runat="server" Text="ISBN:"></asp:Label>
                <asp:TextBox ID="txtISBN" CssClass="form-control" runat="server" placeholder="Ingresar ISBN"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label2" runat="server" Text="Título: "></asp:Label>
                <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server" placeholder="Ingresar Título"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label3" runat="server" Text="Número de Edición: "></asp:Label>
                <asp:TextBox ID="txtEdicion" CssClass="form-control" runat="server" placeholder="Ingresar Número de Edición"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label4" runat="server" Text="Publicación: "></asp:Label>
                <asp:TextBox ID="txtPubli" CssClass="form-control" runat="server" placeholder="Año de Publicación"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label5" runat="server" Text="Autores: "></asp:Label>
                <asp:TextBox ID="txtAutores" CssClass="form-control" runat="server" placeholder="Ingresar Autores"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label6" runat="server" Text="País: "></asp:Label>
                <asp:TextBox ID="txtPais" CssClass="form-control" runat="server" placeholder="Ingresar País"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label7" runat="server" Text="Sinopsis: "></asp:Label>
                <asp:TextBox ID="txtSinopsis" CssClass="form-control" runat="server" placeholder="Añadir una sinopsis"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label8" runat="server" Text="Carrera: "></asp:Label>
                <asp:TextBox ID="txtCarrera" CssClass="form-control" runat="server" placeholder="Carrera a la que se dirige"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label9" runat="server" Text="Materia: "></asp:Label>
                <asp:TextBox ID="txtMateria" CssClass="form-control" runat="server" placeholder="Materia dirigida"></asp:TextBox>
            </div>
            <hr />
            <div class="row">
                <asp:Button ID="btnAnadir" CssClass="btn btn-primary btn-dark" runat="server" Text="AÑADIR" OnClick="btnAnadir_Click"/>
            &nbsp;&nbsp;
                <asp:Button ID="btnRegresar" CssClass="btn btn-primary btn-dark" runat="server" Text="REGRESAR" OnClick="btnRegresar_Click"/>
            </div>
        </div>
    </form>
        </div>
    </div>
</body>
</html>
