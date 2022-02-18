<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarLibro.aspx.cs" Inherits="Proyecto_WebServer.EliminarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
*,::after,::before{box-sizing:border-box}
        .form-control {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ELIMINAR LIBRO<hr />
        </div>
                <asp:GridView ID="dgvLibros" runat="server"></asp:GridView>
            <hr />
            Inserta el ID del libro que desea eliminar:<br />
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" placeholder="Ingresar Título" Width="229px"></asp:TextBox>
            <br />
            <hr />
                <asp:Button ID="btnEliminar" CssClass="btn btn-primary btn-dark" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click"/>
                <asp:Button ID="btnRegresar" CssClass="btn btn-primary btn-dark" runat="server" Text="REGRESAR" OnClick="btnRegresar_Click"/>
    </form>
</body>
</html>
