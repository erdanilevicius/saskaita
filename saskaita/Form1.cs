using System;
using System.Data;
using System.Data.SqlClient;


namespace saskaita
{

    public partial class Form1 : Form
    {

        

        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=projektas; User ID=testas; Password=Aa123456789";
        public string hashed;
        public string salt;
        public string slapt;
        public string pass;
        public string user;

     

        public Form1()
        {
            InitializeComponent();
            regpass.PasswordChar = '*';
            regpass2.PasswordChar = '*';
            logpass.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        /////////////////////////// 
        // Prisijungimo mygtukas //
        ///////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);

            if (String.IsNullOrEmpty(prvard.Text) || String.IsNullOrEmpty(logpass.Text))
            {
                MessageBox.Show("Turite užpildyti visus prisijungimo laukelius!");
            }
            else {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
   
                    SqlCommand cmd = new SqlCommand("SELECT pass FROM dbo.vart WHERE usr='" + prvard.Text + "'", sqlCon);
                    SqlDataReader psw = null;
                    psw = cmd.ExecuteReader();
                    while (psw.Read()) {
                         pass = String.Format("{0}",psw[0]);
                    }
                    string chk = pass.Remove(4, 10);
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    var unhashed = Kodavimas.SDesifravimas(key, chk);

                    if (unhashed == logpass.Text)
                    {
                        MessageBox.Show("Prisijungta sėkmingai ");
                        Form2 Naujas = new Form2();
                        Naujas.Login.Text ="Sveiki, "+ prvard.Text;
                        this.Hide();
                        Naujas.Show();

                        

                    }
                    else {
                        MessageBox.Show("Neteisingas slaptažodis");
                    }

                }
              
            }

        }


        /////////////////////////// 
        //Registracijos mygtukas //
        ///////////////////////////


        private void button2_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);

            if (String.IsNullOrEmpty(regpass.Text) || String.IsNullOrEmpty(regpass2.Text) || String.IsNullOrEmpty(nam.Text))
            {
                MessageBox.Show("Turite užpildyti visus registracijos laukelius!");

            }
            else {
                if (checkBox1.Checked)
                {
                    var uri = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                    var psi = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = uri;
                    System.Diagnostics.Process.Start(psi);

                }
                else
                {

                    if (regpass.Text == regpass2.Text)
                    {
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        var hashed = Kodavimas.SSifravimas(key, regpass.Text);

                        RPG p = new RPG();
                        for (int i = 0; i < 10; i++)
                        {
                            salt = p.GenerateRandomStrongPassword(10);

                        }
                        string password = hashed.Insert(4, salt);

                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.vart (usr,pass) VALUES ('" + nam.Text + "','" + password + "')", sqlCon);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                        }


                        MessageBox.Show("Registracija sėkminga");

                    }
                    else
                    {
                        MessageBox.Show("Suvesti slaptažodžiai nesutampa");
                    }

                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite uždaryti programą ?", "uždaryti", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}