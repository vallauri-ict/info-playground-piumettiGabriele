using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es04_GestioneUtenti
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrati_Click(object sender, EventArgs e)
        {
            // per passare ad altre pagine
            Response.Redirect("registrati.aspx", false);
            lblMessaggio.Text = "Ciao";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }
    }
}