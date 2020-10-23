using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using ADOSQLServer2017_ns;
using System.Data;
using System.Data.SqlClient;
//
using System.Security.Cryptography;
using System.Text;

public class clsDB
    {
        ADOSQLServer2017 ado;
        private string cognome;
        private string nome;
        private string pwd;
        private string username;
        private string dataNascita;
        private string regioneNascita;
        private string provinciaNascita;
        private string comuneNascita;


        public string Cognome {
            get { return cognome; }
            set {
                if (value.Length < 3)
                    throw new Exception("Cognome non valido");
                else
                    cognome = value;
            }
        }

        public string Nome {
            get { return nome; }
            set
            {
                if (value.Length < 3)
                    throw new Exception("Password non valida");
                else
                    nome = value;
            }
        }
        public string Pwd {
            get { return pwd; }
            set {
                if (value.Length > 7)
                    pwd = this.sha256(value);
                else
                    throw new Exception("Nome non valido");
            }
        }

        public string DataNascita
        {
            get { return dataNascita; }
            set
            {
                if (value.Length < 10)
                    throw new Exception("Data di nascita non valido");
                else
                    dataNascita = value;
            }
        }

        public string RegioneNascita {
            get {
                return regioneNascita;
            }
            set {
                if (value != "-1")
                {
                    regioneNascita = ""+Convert.ToInt32(value);
                }
            }
        }

        public string ProvinciaNascita {
            get {
                return provinciaNascita;
            } 
            set{
                if (value != "-1")
                {
                    regioneNascita = ""+Convert.ToInt32(value);
                }
            }
        }

        public string ComuneNascita {
            get {
                return comuneNascita;
            }
            set{
                if (value != "-1")
                {
                    regioneNascita = ""+Convert.ToInt32(value);
                }
            }
        }


        public clsDB(string nomeDB)
        {
            this.ado = new ADOSQLServer2017(nomeDB);
        }

    

        public DataTable caricaRegioni()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * ";
            cmd.CommandText += "FROM Regioni ";
            cmd.CommandText += "ORDER BY Regione ";
            cmd.CommandType = CommandType.Text;
            return ado.EseguiQuery(cmd);
        }

        public DataTable caricaProvince(string idRegione)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * ";
            cmd.CommandText += "FROM Province ";
            cmd.CommandText += "WHERE idRegione=@idRegione ";
            cmd.CommandText += "ORDER BY Provincia ";
            cmd.Parameters.AddWithValue("@idRegione", idRegione);
            cmd.CommandType = CommandType.Text;
            return ado.EseguiQuery(cmd);
        }

        public DataTable caricaComuni(string idProvincia)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * ";
            cmd.CommandText += "FROM Comuni ";
            cmd.CommandText += "WHERE idProvincia=@idProvincia ";
            cmd.CommandText += "ORDER BY Comune ";
            cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
            cmd.CommandType = CommandType.Text;
            return ado.EseguiQuery(cmd);
        }

        public void inserisciUtente()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Utenti (cognome, nome, username, pwd, dataNascita, regioneNascita, provinciaNascita, comuneNascita)" +
                "VALUES (@cognome, @nome, @username, @pwd, @dataNascita, @regioneNascita, @provinciaNascita, @comuneNascita)";
            cmd.Parameters.AddWithValue("@cognome", cognome);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@dataNascita", dataNascita);
            cmd.Parameters.AddWithValue("@regioneNascita", RegioneNascita);
            cmd.Parameters.AddWithValue("@provinciaNascita", ProvinciaNascita);
            cmd.Parameters.AddWithValue("@comuneNascita", ComuneNascita);
            ado.EseguiQuery(cmd);
        }

        public string sha256(string pwd)
        {
            string p = "";
            SHA256 mySHA256 = SHA256.Create();
            //calcolo codice hash 
            byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashValue.Length; i++)
            {
                builder.Append(hashValue[i].ToString("x2")); //converto in esadecimale
            }
            p = builder.ToString();
            return p;
        }

    public bool controllaUsername(string userName)
    {
        bool esito = false;
        DataTable dt;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM Utenti WHERE username = @user";
        cmd.Parameters.AddWithValue("@user", userName);
        dt = ado.EseguiQuery(cmd);
        if (dt.Rows.Count > 0)
            esito = true;
        return esito;
    }
}