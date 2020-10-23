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
        clsDB db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new clsDB("AppData\\db_Biblioteca.mdf");
            //if (!Page.IsPostBack)
            //popolaCmbRegioni();
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
                db.Username = txtUsername.Text;
                db.Pwd = txtPwd.Text;
                //if (db.login())
                //    lblMessaggio.Text = "Login OK";
                //else
                {
                    Session["idUtente"] = idUtente;
                    Response.Redirect("settaglioUtente.aspx", false);
                }
                //    lblMessaggio.Text = "Credenziali non valide!";
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }
    }
}