<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarLibro.aspx.cs" Inherits="Proyecto_WebServer.ModificarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
*{box-sizing:border-box}
        .form-control {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            MODIFICAR LIBRO<hr />
        </div>
                <asp:GridView ID="dgvLibros" runat="server"></asp:GridView>
            <hr />
            Inserta el ID del libro a que desea modificar:<br />
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" placeholder="Ingresar Título" Width="229px"></asp:TextBox>
            <br />
            <hr />
            ISBN:<div class="auto_style1">
                <asp:TextBox ID="txtISBN" CssClass="form-control" runat="server" placeholder="Ingresar ISBN" Width="304px"></asp:TextBox>
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label2" runat="server" Text="Título: "></asp:Label>
            </div>
                <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server" placeholder="Ingresar Título" Width="536px"></asp:TextBox>
            <br />
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label3" runat="server" Text="Número de Edición: "></asp:Label>
            </div>
                <asp:TextBox ID="txtEdicion" CssClass="form-control" runat="server" placeholder="Ingresar Número de Edición" Width="232px"></asp:TextBox>
            <br />
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label4" runat="server" Text="Publicación: "></asp:Label>
            </div>
                <asp:TextBox ID="txtPubli" CssClass="form-control" runat="server" placeholder="Año de Publicación" Width="247px"></asp:TextBox>
            <br />
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label5" runat="server" Text="Autores: "></asp:Label>
                <br />
                <asp:TextBox ID="txtAutores" CssClass="form-control" runat="server" placeholder="Ingresar Autores" Width="505px"></asp:TextBox>
            <hr />
            </div>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label6" runat="server" Text="País: "></asp:Label>
            </div>
                <asp:TextBox ID="txtPais" CssClass="form-control" runat="server" placeholder="Ingresar País" Width="257px"></asp:TextBox>
            <br />
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label7" runat="server" Text="Sinopsis: "></asp:Label>
            </div>
                <asp:TextBox ID="txtSinopsis" CssClass="form-control" runat="server" placeholder="Añadir una sinopsis" Height="23px" Width="695px"></asp:TextBox>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label8" runat="server" Text="Carrera: "></asp:Label>
            </div>
                <asp:TextBox ID="txtCarrera" CssClass="form-control" runat="server" placeholder="Carrera a la que se dirige" Width="330px"></asp:TextBox>
            <hr />
            <div class="auto_style1">
                <asp:Label ID="Label9" runat="server" Text="Materia: "></asp:Label>
                <br />
                <asp:TextBox ID="txtMateria" CssClass="form-control" runat="server" placeholder="Materia dirigida" Width="330px"></asp:TextBox>
                <br />
            <hr />
                <br />
                <asp:Button ID="btnModificar" CssClass="btn btn-primary btn-dark" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRegresar" CssClass="btn btn-primary btn-dark" runat="server" Text="REGRESAR" OnClick="btnRegresar_Click"/>
                <br />
            </div>
            <p>
                &nbsp;</p>
    </form>
</body>
</html>
