using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piumettiEsercizioTrigger
{
    public partial class frmMain : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\bin\debug\clienti.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter dataAdapterCliente;
        SqlDataAdapter dataAdapterCanc;
        SqlDataAdapter dataAdapterAgg;

        clsDB db;
        int rigaCorrente = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            db = new clsDB("Clienti.mdf");
            dgvStorico.DataSource = db.getStoricoCanc();
            dgvClienti.DataSource = db.getClienti();
            dgvAgg.DataSource = db.getStoricaUpdate();
            //caricaClienti();
        }

        //public void caricaClienti()
        //{
        //    dataAdapterCliente = null;
        //    dataAdapterCanc = null;
        //    dataAdapterAgg = null;
        //    dataAdapterCliente = new SqlDataAdapter("SELECT * FROM Cliente", conn);
        //    SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapterCliente);
        //    if (dataAdapterCliente != null)
        //    {
        //        DataTable a = new DataTable();
        //        dataAdapterCliente.Fill(a);
        //        dgvClienti.DataSource = a;
        //    }
        //    dataAdapterCanc = new SqlDataAdapter("SELECT * FROM storicoCancellazioni", conn);
        //    SqlCommandBuilder cmd2 = new SqlCommandBuilder(dataAdapterCanc);
        //    if (dataAdapterCanc != null)
        //    {
        //        DataTable d = new DataTable();
        //        dataAdapterCanc.Fill(d);
        //        dgvStorico.DataSource = d;
        //    }
        //    dataAdapterCliente = new SqlDataAdapter("SELECT * FROM storicoUpdate", conn);
        //    SqlCommandBuilder cmd3 = new SqlCommandBuilder(dataAdapterAgg);
        //    if (dataAdapterAgg != null)
        //    {
        //        DataTable b = new DataTable();
        //        dataAdapterAgg.Fill(b);
        //        dgvAgg.DataSource = b;
        //    }
        //}

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            db.aggiungiCliente(txtNomeAdd.Text, txtCognomeAdd.Text);
            dgvClienti.DataSource = db.getClienti();
            dgvStorico.DataSource = db.getStoricoCanc();
            dgvAgg.DataSource = db.getStoricaUpdate();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            db.modificaCliente(rigaCorrente, txtModificaNome.Text, txtModificaCognome.Text);
            dgvClienti.DataSource = db.getClienti();
            dgvStorico.DataSource = db.getStoricoCanc();
            dgvAgg.DataSource = db.getStoricaUpdate();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            db.cancellaCliente(rigaCorrente);
            dgvClienti.DataSource = db.getClienti();
            dgvStorico.DataSource = db.getStoricoCanc();
            dgvAgg.DataSource = db.getStoricaUpdate();
        }

        private void dgvClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaCorrente = Convert.ToInt32(dgvClienti.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
