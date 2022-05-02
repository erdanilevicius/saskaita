using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace saskaita
{
    public partial class Form3 : Form
    {

        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=projektas; User ID=testas; Password=Aa123456789";

        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.imon (impav,imkod,adr,bank,sas,pvmkod) VALUES ('" + impv.Text + "','" + imkod.Text + "','"+adrs.Text+"','"+bankas.Text+"','LT"+snr.Text+"','"+pvmkod.Text+"')", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Naujas = new Form2();
            Naujas.Login.Text = "";
            this.Hide();
            Naujas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dbo.imon", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Gridas.DataSource = dtbl;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite uždaryti programą ?", "uždaryti", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
