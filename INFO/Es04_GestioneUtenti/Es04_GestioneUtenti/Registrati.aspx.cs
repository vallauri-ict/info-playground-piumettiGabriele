using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Es04_GestioneUtenti
{
    public partial class Registrati : System.Web.UI.Page
    {

        clsDB db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new clsDB("App_Data\\Biblioteca.mdf");
            //if (!Page.IsPostBack)
            //    popolaCmbRegioni();
        }

        protected void btnRegistrati_Click(object sender, EventArgs e)
        {
            // TO DO controlli input
            try
            {
                db.Cognome = txtCognome.Text;
                db.Nome = txtNome.Text;
                db.DataNascita = txtDataNascita.Text;
                db.Pwd = db.sha256(txtPwd.Text);
                db.RegioneNascita = cmbRegione.SelectedIndex.ToString();
                db.ProvinciaNascita = cmbProvincia.SelectedIndex.ToString();
                db.ComuneNascita = cmbComune.SelectedIndex.ToString();
                db.inserisciUtente();
                //
                lblMessaggio.Text = "Utente inserito correttamente";
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = "Errore " + ex.Message.ToString();
            }
        }

        

    
}
}