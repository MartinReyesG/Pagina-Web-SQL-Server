<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Proyecto_WebServer.Principal" %>

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
            <div class="auto_style1">
                LIBRERIA 
            </div>
            <br />
            <div>
                <asp:GridView ID="dgvLibros" runat="server"></asp:GridView>
            </div>
            <div class="auto_style1">
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </div>
        </div>
    </form>
</body>
</html>
