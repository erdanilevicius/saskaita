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
    public partial class Prekes : Form
    {
        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=projektas; User ID=testas; Password=Aa123456789";
        public string pvmas;
        public string sum;
        public int galas;
        public string gal;

        public Prekes()
        {
            InitializeComponent();
            label5.Text = "Dabartinis PVM yra: " + PVMGavimas().Trim() + "%";
        }

        ///////////////////////
        // PVM gavimas is DB //
        ///////////////////////
        public string PVMGavimas() {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT pvm FROM dbo.pvm WHERE pvmid= 1", sqlCon);
                SqlDataReader pvm = null;
                pvm = cmd.ExecuteReader();
                while (pvm.Read())
                {
                    pvmas = String.Format("{0}", pvm[0]);
                }

                
            }
            return pvmas;
        }

        ///////////////////////////////
        // Kainos su PVM keitamas DB //
        ///////////////////////////////
        public void Keitimas() {

            int i = 1;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT id FROM dbo.preke", sqlCon);
                SqlDataReader gl = null;
                gl = cmd.ExecuteReader();
                while (gl.Read())
                {
                     gal = String.Format("{0}", gl[0]);
                }
                galas = Int32.Parse(gal);

            }




            while (i <= galas){
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT kainb FROM dbo.preke WHERE id= " + i + "", sqlCon);
                    SqlDataReader suma = null;
                    suma = cmd.ExecuteReader();
                    while (suma.Read())
                    {
                        sum = String.Format("{0}", suma[0]);
                    }


                }

                double keisti = (double.Parse(PVMGavimas()) / 100 + 1) * double.Parse(sum);

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.preke SET sum = '"+keisti+"' WHERE id = '"+i+"'", sqlCon);
                    SqlDataReader suma = null;
                    suma = cmd.ExecuteReader();
                    while (suma.Read())
                    {
                        sum = String.Format("{0}", suma[0]);
                    }


                }
                i++;

            }


        }

        ////////////////////
        // sugrizti atgal //
        ////////////////////

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Naujas = new Form2();
            Naujas.Login.Text = "";
            this.Hide();
            Naujas.Show();
        }
        /////////////////////////
        // uzdaryti aplikacija //
        /////////////////////////

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite uždaryti programą ?", "uždaryti", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //////////////////
        // Nauja preke  //
        //////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            double suma = (double.Parse(PVMGavimas())/100+1)*double.Parse(Kain.Text);


            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.preke (prek,kainb,pvm,sum) VALUES ('" + Prek.Text + "','" + Kain.Text + "','"+pvmas+"','"+suma+"')", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
            }
        }

        ////////////////////
        // Prekiu rodymas //
        ////////////////////

        private void button3_Click(object sender, EventArgs e)
        {

            this.Keitimas();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dbo.preke", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridas.DataSource = dtbl;

            }



        }

        //////////////////
        // PVM Keitimas //
        //////////////////
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("UPDATE dbo.pvm SET pvm = '"+Keit.Text+"'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("UPDATE dbo.preke SET pvm = '" + Keit.Text + "'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

            }

            label5.Text = "Dabartinis PVM yra: " + PVMGavimas().Trim() + "%";

        }
    }
}
