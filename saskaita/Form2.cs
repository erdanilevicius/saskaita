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

    public partial class Form2 : Form
    {

        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=projektas; User ID=testas; Password=Aa123456789";
        public string unr;
        public int eile;
        public int check;

        public Form2()
        {
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite uždaryti programą ?", "uždaryti", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Naujas = new Form3();
            this.Hide();
            Naujas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prekes Naujas = new Prekes();
            this.Hide();
            Naujas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int j = 1;
            string num;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT unr FROM dbo.uzsakymas", sqlCon);
                SqlDataReader uzk = null;
                uzk = cmd.ExecuteReader();
                while (uzk.Read())
                {
                    unr = String.Format("{0}", uzk[0]);
                }
                check = Int32.Parse(unr.Trim());
            }
            while (j != 0) {

                if (unr == null)
                {
                    eile = j;
                    Uzk f2 = new Uzk(eile);
                    this.Hide();
                    f2.Show();

                    j = 0;

                }
                else {
                        eile = check+1;
                        Uzk f2 = new Uzk(eile);
                        this.Hide();
                        f2.Show();
                        j = 0;
                    
                } 
                 
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {
            var uri = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);


        }
    }
}
