using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_WebServer.DAO;
using Proyecto_WebServer.MODELO;
using System.Data;

namespace Proyecto_WebServer
{
    public partial class AnadirLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAnadir_Click(object sender, EventArgs e)
        {
            Libro obj = new Libro();
            DAOLibro objLibro = new DAOLibro();

            obj.ISBN = txtISBN.Text;
            obj.Titulo = txtTitulo.Text;
            obj.NumeroEdicion = Convert.ToInt32(txtEdicion.Text);
            obj.AnioPublicacion = Convert.ToInt32(txtPubli.Text);
            obj.Autores = txtAutores.Text;
            obj.Pais = txtPais.Text;
            obj.Sinopsis = txtSinopsis.Text;
            obj.Carrera = txtCarrera.Text;
            obj.Materia = txtMateria.Text;

            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtEdicion.Text = "";
            txtPubli.Text = "";
            txtAutores.Text = "";
            txtPais.Text = "";
            txtSinopsis.Text = "";
            txtCarrera.Text = "";
            txtMateria.Text = "";

            objLibro.Insertar(obj);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}