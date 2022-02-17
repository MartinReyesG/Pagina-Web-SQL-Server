using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_WebServer.DAO;

namespace Proyecto_WebServer
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            DAOLibro obj = new DAOLibro();
            dgvLibros.DataSource = obj.lstLibros();
            dgvLibros.DataBind();
        }

        protected void btnAnadir_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnadirLibro.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}