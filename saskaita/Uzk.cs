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
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Pdfa;
using System.IO;

namespace saskaita
{
    public partial class Uzk : Form
    {
        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=projektas; User ID=testas; Password=Aa123456789";
        public string preke;
        public string id;
        public int identity;
        public string imonid;
        public int imon;
        public string imone;
        public string kainb;
        public string sum;
        public string pvmas;
        public string eile;
        public int eil;
        public double pvma;
        public double pirmas;
        public double antras;
        public double visaSum;
        public double pvmSum;
        public double bendrSum;
        public string imkodas1;
        public string adresas1;
        public string bankas1;
        public string saskaita1;
        public string pvmkodas1;
        public string imkodas2;
        public string adresas2;
        public string bankas2;
        public string saskaita2;
        public string pvmkodas2;
        public string eilesnr;
        public string prk;
        public string kk;
        public string kn;
        public string nsum;
        public string pvvm;
        public string pvms;
        public string prksum;



        public static int ska;
        public Uzk(int sk)
        {
            InitializeComponent();
            ska = sk;     
        }

        public string PVMGavimas()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Naujas = new Form2();
            Naujas.Login.Text = "";
            this.Hide();
            Naujas.Show();
        }

        private void Pasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Kiek;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("SELECT kainb,sum FROM dbo.preke WHERE prek= '" + Pasirinkimas.Text + "'", sqlCon);
                SqlDataReader kaina = null;
                kaina = command.ExecuteReader();
                while (kaina.Read())
                {
                    kainb = String.Format("{0}", kaina[0]);
                    sum = String.Format("{0}", kaina[1]);
                }
            }

            pvma = double.Parse(sum.Trim()) - double.Parse(kainb.Trim());
            

            if (String.IsNullOrEmpty(Kiekis.Text))
            {
                Kiek = 1;
                pirmas = double.Parse(kainb.Trim()) * Kiek;
                antras = double.Parse(sum.Trim()) * Kiek;

                Be.Text = "Prekės kaina be PVM: " + pirmas + "€";
                PVM.Text = "PVM suma: " + Math.Round(pvma, 2) * Kiek + "€";
                preksum.Text = "Prekių suma: " + antras + "€";
            }
            else {
                Kiek = Int32.Parse(Kiekis.Text);

                pirmas = double.Parse(kainb.Trim()) * Kiek;
                antras = double.Parse(sum.Trim()) * Kiek;
                pvma = pvma * Kiek;

                Be.Text = "Prekės kaina be PVM: " + pirmas + "€";
                PVM.Text = "PVM suma: " + Math.Round(pvma, 2)+ "€";
                preksum.Text = "Prekių suma: " + Math.Round(antras, 2) + "€";
            }
        }

        private void Uzk_Load(object sender, EventArgs e)
        {
            int j = 1;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT id FROM dbo.preke ", sqlCon);
                SqlDataReader iden = null;
                iden = cmd.ExecuteReader();
                while (iden.Read()){
                    id = String.Format("{0}", iden[0]);
                }
                identity = Int32.Parse(id);
            }
            while (j <= identity)
            {
                if (j == 2){
                    j++;
                }
                else {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("SELECT prek FROM dbo.preke WHERE id= " + j + "", sqlCon);
                        SqlDataReader prek = null;
                        prek = cmd.ExecuteReader();
                        while (prek.Read())
                        {
                            preke = String.Format("{0}", prek[0]);
                        }
                    }
                    Pasirinkimas.Items.Add(preke);
                    j++;
                } 
            }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmm = new SqlCommand("SELECT id FROM dbo.imon", sqlCon);
                SqlDataReader imn = null;
                imn = cmm.ExecuteReader();
                while (imn.Read())
                {
                    imonid = String.Format("{0}", imn[0]);
                }
                imon = Int32.Parse(imonid);
            }
            int k = 1;

            while (k <= imon) {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT impav FROM dbo.imon WHERE id= " + k + "", sqlCon);
                    SqlDataReader rand = null;
                    rand = cmd.ExecuteReader();
                    while (rand.Read())
                    {
                        imone = String.Format("{0}", rand[0]);
                    }
                }
                pirkejas.Items.Add(imone);
                pardavejas.Items.Add(imone);

                k++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite uždaryti programą ?", "uždaryti", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 1;
            int check;
            string num;
            double sum2;
            double sum1;
            double sum3;
            while (n != 0) {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT eilnr FROM dbo.uzsakymas WHERE unr = '" + ska + "'", sqlCon);
                    SqlDataReader uzk = null;
                    uzk = cmd.ExecuteReader();
                    while (uzk.Read())
                    {
                        eile = String.Format("{0}", uzk[0]);
                    }
                    
                }
             
                if (eile == null)
                {
                    eil = n;
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.uzsakymas (eilnr,unr,pirk,pard,prek,kiek,kain,nsum,pvm,pvms,prksum) " +
                       "VALUES ('" + eil + "','" + ska + "','" + pirkejas.Text + "','" + pardavejas.Text + "','" + Pasirinkimas.Text + "','" + Kiekis.Text + "','" + kainb + "'," +
                       "'" + Math.Round(pirmas, 2) + "','" + PVMGavimas().Trim() + "%','" + Math.Round(pvma, 2) + "','" + Math.Round(antras, 2) + "')", sqlCon);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        Uzsakymas.DataSource = dtbl;
                        sum2 = Math.Round(antras, 2);
                        visaSum = visaSum + sum2;
                        sum1 = Math.Round(pvma, 2);
                        pvmSum = pvmSum + sum1;
                        sum3 = Math.Round(pirmas, 2);
                        bendrSum = bendrSum + sum3;

                    }

                    n = 0;
                }
                else {
                        check = Int32.Parse(eile);
                        eil = check+1;
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.uzsakymas (eilnr,unr,pirk,pard,prek,kiek,kain,nsum,pvm,pvms,prksum) " +
                           "VALUES ('" + eil + "','" + ska + "','" + pirkejas.Text + "','" + pardavejas.Text + "','" + Pasirinkimas.Text + "','" + Kiekis.Text + "','" + kainb + "'," +
                           "'" + Math.Round(pirmas, 2) + "','" + PVMGavimas().Trim() + "%','" + Math.Round(pvma, 2) + "','" + Math.Round(antras, 2) + "')", sqlCon);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            Uzsakymas.DataSource = dtbl;
                            sum2 = Math.Round(antras, 2);
                            visaSum = visaSum + sum2;
                            sum1 = Math.Round(pvma, 2);
                            pvmSum = pvmSum + sum1;
                            sum3 = Math.Round(pirmas, 2);
                            bendrSum = bendrSum + sum3;
                        }
                        n = 0;
                    
                }
                
                bendr.Text = "Visų prekių suma:" + Math.Round(visaSum, 2) + "€";

            }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM dbo.uzsakymas Where unr = '"+ska+"'AND pirk = '"+pirkejas.Text+"'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Uzsakymas.DataSource = dtbl;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string data = DateTime.Today.ToShortDateString();
            int eilute;


            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("INSERT INTO dbo.uzk (unr,sumb,pvmsum,bendr,data) VALUES ('"+ska+"', '"+Math.Round(bendrSum,2)+"','"+ Math.Round(pvmSum,2) +"','"+ Math.Round(visaSum,2) +"','"+data+"')", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT eilnr FROM dbo.uzsakymas WHERE unr = "+ska+" ", sqlCon);
                SqlDataReader iden = null;
                iden = cmd.ExecuteReader();
                while (iden.Read())
                {
                    eilesnr = String.Format("{0}", iden[0]);
                }
                eilute = Int32.Parse(eilesnr);
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT imkod,adr,bank,sas,pvmkod FROM dbo.imon WHERE impav= '" + pirkejas.Text + "'", sqlCon);
                    SqlDataReader rand = null;
                    rand = cmd.ExecuteReader();
                    while (rand.Read())
                    {
                        imkodas2 = String.Format("{0}", rand[0]);
                        adresas2 = String.Format("{0}", rand[1]);
                        bankas2 = String.Format("{0}", rand[2]);
                        saskaita2 = String.Format("{0}", rand[3]);
                        pvmkodas2 = String.Format("{0}", rand[0]);
                    }
                }
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT imkod,adr,bank,sas,pvmkod FROM dbo.imon WHERE impav= '" + pardavejas.Text + "'", sqlCon);
                SqlDataReader rand = null;
                rand = cmd.ExecuteReader();
                while (rand.Read())
                {
                    imkodas1 = String.Format("{0}", rand[0]);
                    adresas1 = String.Format("{0}", rand[1]);
                    bankas1 = String.Format("{0}", rand[2]);
                    saskaita1 = String.Format("{0}", rand[3]);
                    pvmkodas1 = String.Format("{0}", rand[0]);
                }
            }

            PdfWriter writer = new PdfWriter("failai/" + DateTime.Now.ToString("yyyyMMddHHmm")+".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("PVM SASKAITA - FAKTURA ").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            Paragraph subheader = new Paragraph("Užsakymo numeris: "+ska.ToString()).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15);
            Paragraph subheader2 = new Paragraph(data).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15);


            document.Add(header);
            document.Add(subheader);
            document.Add(subheader2);

            Table table = new Table(5, false);
            Cell cell11 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Pardavejas:"));
            Cell cell12 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(pardavejas.Text));
            Cell cell13 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell14 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Pirkejas: "));
            Cell cell15 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(pirkejas.Text));

            Cell cell21 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Imones kodas: "));
            Cell cell22 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(imkodas2));
            Cell cell23 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell24 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Imones kodas: "));
            Cell cell25 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(imkodas1));

            Cell cell31 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Adresas: "));
            Cell cell32 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(adresas1));
            Cell cell33 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell34 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Adresas: "));
            Cell cell35 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(adresas2));

            Cell cell41 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("PVM kodas: "));
            Cell cell42 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(pvmkodas1));
            Cell cell43 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell44 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("PVM kodas:"));
            Cell cell45 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(pvmkodas2));

            Cell cell51 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("A/S: "));
            Cell cell52 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(saskaita1)) ;
            Cell cell53 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell54 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell55 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));

            Cell cell61 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Bankas: "));
            Cell cell62 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(bankas1));
            Cell cell63 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell64 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));
            Cell cell65 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("      "));


            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);
            table.AddCell(cell14);
            table.AddCell(cell15);

            table.AddCell(cell21);
            table.AddCell(cell22);
            table.AddCell(cell23);
            table.AddCell(cell24);
            table.AddCell(cell25);

            table.AddCell(cell31);
            table.AddCell(cell32);
            table.AddCell(cell33);
            table.AddCell(cell34);
            table.AddCell(cell35);

            table.AddCell(cell41);
            table.AddCell(cell42);
            table.AddCell(cell43);
            table.AddCell(cell44);
            table.AddCell(cell45);

            table.AddCell(cell51);
            table.AddCell(cell52);
            table.AddCell(cell53);
            table.AddCell(cell54);
            table.AddCell(cell55);

            table.AddCell(cell61);
            table.AddCell(cell62);
            table.AddCell(cell63);
            table.AddCell(cell64);
            table.AddCell(cell65);

            document.Add(table);


            Table lentele = new Table(9, false);
            Cell lang11 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("EIL.NR"));
            Cell lang12 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("PAVADINIMAS"));
            Cell lang13 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("MAT.VNT"));
            Cell lang14 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("KIEKIS"));
            Cell lang15 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("KAINA(BE PVM)"));
            Cell lang16 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("SUMA(BE PVM)"));
            Cell lang17 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("PVM %"));
            Cell lang18 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("PVM"));
            Cell lang19 = new Cell(1, 1).SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("IŠ VISO"));

            lentele.AddCell(lang11);
            lentele.AddCell(lang12);
            lentele.AddCell(lang13);
            lentele.AddCell(lang14);
            lentele.AddCell(lang15);
            lentele.AddCell(lang16);
            lentele.AddCell(lang17);
            lentele.AddCell(lang18);
            lentele.AddCell(lang19);

            int i = 1;

            while (i <= eilute) {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT prek,kiek,kain,nsum,pvm,pvms,prksum FROM dbo.uzsakymas WHERE unr = " + ska + " AND eilnr = "+i+" ", sqlCon);
                    SqlDataReader iden = null;
                    iden = cmd.ExecuteReader();
                    while (iden.Read())
                    {
                        prk = String.Format("{0}", iden[0]);
                        kk = String.Format("{0}", iden[1]);
                        kn = String.Format("{0}", iden[2]);
                        nsum = String.Format("{0}", iden[3]);
                        pvvm = String.Format("{0}", iden[4]);
                        pvms = String.Format("{0}", iden[5]);
                        prksum = String.Format("{0}", iden[6]);
                    }
                }

                Cell pirmas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(i.ToString()));
                Cell antras = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(prk));
                Cell trecias = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("vnt."));
                Cell ketvirtas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(kk));
                Cell penktas = new Cell(1, 1).SetTextAlignment (TextAlignment.CENTER).Add(new Paragraph(kn));
                Cell sestas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(nsum));
                Cell septintas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(pvvm));
                Cell astuntas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(pvms));
                Cell devintas = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(prksum));


                lentele.AddCell(pirmas);
                lentele.AddCell(antras);
                lentele.AddCell(trecias);
                lentele.AddCell(ketvirtas);
                lentele.AddCell(penktas);
                lentele.AddCell(sestas);
                lentele.AddCell(septintas);
                lentele.AddCell(astuntas);
                lentele.AddCell(devintas);


                i++;
            }
            document.Add(lentele);


            Table mokestis = new Table(2, false).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);

            Cell ltl11 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Iš viso (be PVM):"));
            Cell ltl12 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(Math.Round(bendrSum, 2).ToString()+ "€"));

            Cell ltl21 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("PVM:"));
            Cell ltl22 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(Math.Round(pvmSum, 2).ToString() + "€"));

            Cell ltl31 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph("Iš viso (su PVM):"));
            Cell ltl32 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).SetBorder(iText.Layout.Borders.Border.NO_BORDER).Add(new Paragraph(Math.Round(visaSum, 2).ToString()+ "€"));


            mokestis.AddCell(ltl11);
            mokestis.AddCell(ltl12);
            mokestis.AddCell(ltl21);
            mokestis.AddCell(ltl22);
            mokestis.AddCell(ltl31);
            mokestis.AddCell(ltl32);

            document.Add(mokestis);

            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);
            document.Close();


            MessageBox.Show("PDF failas buvo sukurtas sėkmingai");
        }
    }
}

