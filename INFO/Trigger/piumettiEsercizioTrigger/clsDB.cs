using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADOSQLServer2017_ns;

namespace piumettiEsercizioTrigger
{
    class clsDB
    {
        ADOSQLServer2017 ado;
        public clsDB(string db)
        {
            this.ado = new ADOSQLServer2017(db);
        }
        public DataTable getClienti()
        {
            DataTable dt;
            SqlCommand sql = new SqlCommand("SELECT * FROM Cliente");
            dt = ado.EseguiQuery(sql);
            return dt;
        }

        public DataTable getStoricoCanc()
        {
            DataTable dt;
            SqlCommand sql = new SqlCommand("SELECT * FROM storicoCancellazioni");
            dt = ado.EseguiQuery(sql);
            return dt;
        }

        public DataTable getStoricaUpdate()
        {
            DataTable dt;
            SqlCommand sql = new SqlCommand("SELECT * FROM storicoUpdate");
            dt = ado.EseguiQuery(sql);
            return dt;
        }

        public void modificaCliente(int id, string nome, string cognome)
        {
            SqlCommand sql = new SqlCommand("UPDATE Cliente SET Nome = @nome, Cognome = @cognome WHERE IdCliente = @id");
            sql.Parameters.AddWithValue("@nome", nome);
            sql.Parameters.AddWithValue("@cognome", cognome);
            sql.Parameters.AddWithValue("@id", id);
            ado.EseguiScalar(sql);
        }

        public void aggiungiCliente(string nome, string cognome)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO Cliente (Nome, Cognome) VALUES(@nome, @cognome)");
            sql.Parameters.AddWithValue("@nome", nome);
            sql.Parameters.AddWithValue("@cognome", cognome);
            ado.EseguiScalar(sql);
        }

        public void cancellaCliente(int id)
        {
            SqlCommand sql = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @id");
            sql.Parameters.AddWithValue("@id", id);
            ado.EseguiScalar(sql);
        }
    }
}
