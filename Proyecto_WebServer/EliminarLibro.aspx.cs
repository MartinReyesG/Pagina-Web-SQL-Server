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
    public partial class EliminarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAOLibro obj = new DAOLibro();
            dgvLibros.DataSource = obj.lstLibros();
            dgvLibros.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            DAOLibro obj = new DAOLibro();

            bool a = obj.eliminar(int.Parse(txtID.Text.ToString()));

            txtID.Text = "";

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = obj.lstLibros();
            dgvLibros.DataBind();
        }
    }
}