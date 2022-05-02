namespace saskaita
{
    partial class Uzk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Pasirinkimas = new System.Windows.Forms.ComboBox();
            this.pirkejas = new System.Windows.Forms.ComboBox();
            this.pardavejas = new System.Windows.Forms.ComboBox();
            this.Kiekis = new System.Windows.Forms.TextBox();
            this.Be = new System.Windows.Forms.Label();
            this.PVM = new System.Windows.Forms.Label();
            this.preksum = new System.Windows.Forms.Label();
            this.bendr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Uzsakymas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Uzsakymas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pasirinkimas
            // 
            this.Pasirinkimas.FormattingEnabled = true;
            this.Pasirinkimas.Location = new System.Drawing.Point(33, 164);
            this.Pasirinkimas.Name = "Pasirinkimas";
            this.Pasirinkimas.Size = new System.Drawing.Size(121, 23);
            this.Pasirinkimas.TabIndex = 1;
            this.Pasirinkimas.SelectedIndexChanged += new System.EventHandler(this.Pasirinkimas_SelectedIndexChanged);
            // 
            // pirkejas
            // 
            this.pirkejas.FormattingEnabled = true;
            this.pirkejas.Location = new System.Drawing.Point(33, 48);
            this.pirkejas.Name = "pirkejas";
            this.pirkejas.Size = new System.Drawing.Size(121, 23);
            this.pirkejas.TabIndex = 2;
            // 
            // pardavejas
            // 
            this.pardavejas.FormattingEnabled = true;
            this.pardavejas.Location = new System.Drawing.Point(33, 108);
            this.pardavejas.Name = "pardavejas";
            this.pardavejas.Size = new System.Drawing.Size(121, 23);
            this.pardavejas.TabIndex = 3;
            // 
            // Kiekis
            // 
            this.Kiekis.Location = new System.Drawing.Point(33, 221);
            this.Kiekis.Name = "Kiekis";
            this.Kiekis.Size = new System.Drawing.Size(121, 23);
            this.Kiekis.TabIndex = 4;
            // 
            // Be
            // 
            this.Be.AutoSize = true;
            this.Be.Location = new System.Drawing.Point(31, 274);
            this.Be.Name = "Be";
            this.Be.Size = new System.Drawing.Size(125, 15);
            this.Be.TabIndex = 5;
            this.Be.Text = "Prekės kaina be PVM : ";
            // 
            // PVM
            // 
            this.PVM.AutoSize = true;
            this.PVM.Location = new System.Drawing.Point(31, 308);
            this.PVM.Name = "PVM";
            this.PVM.Size = new System.Drawing.Size(70, 15);
            this.PVM.TabIndex = 6;
            this.PVM.Text = "PVM suma :";
            // 
            // preksum
            // 
            this.preksum.AutoSize = true;
            this.preksum.Location = new System.Drawing.Point(31, 342);
            this.preksum.Name = "preksum";
            this.preksum.Size = new System.Drawing.Size(81, 15);
            this.preksum.TabIndex = 7;
            this.preksum.Text = "Prekės kaina : ";
            // 
            // bendr
            // 
            this.bendr.AutoSize = true;
            this.bendr.Location = new System.Drawing.Point(210, 54);
            this.bendr.Name = "bendr";
            this.bendr.Size = new System.Drawing.Size(102, 15);
            this.bendr.TabIndex = 8;
            this.bendr.Text = "Visų prekių kaina: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pridėti prekes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Patvirtinti užsakymą";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Uždaryti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Uzsakymas
            // 
            this.Uzsakymas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Uzsakymas.Location = new System.Drawing.Point(12, 423);
            this.Uzsakymas.Name = "Uzsakymas";
            this.Uzsakymas.RowTemplate.Height = 25;
            this.Uzsakymas.Size = new System.Drawing.Size(618, 203);
            this.Uzsakymas.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pirkėjas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pardavėjas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prekė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kiekis";
            // 
            // Uzk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 652);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uzsakymas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bendr);
            this.Controls.Add(this.preksum);
            this.Controls.Add(this.PVM);
            this.Controls.Add(this.Be);
            this.Controls.Add(this.Kiekis);
            this.Controls.Add(this.pardavejas);
            this.Controls.Add(this.pirkejas);
            this.Controls.Add(this.Pasirinkimas);
            this.Controls.Add(this.button1);
            this.Name = "Uzk";
            this.Text = "Uzk";
            this.Load += new System.EventHandler(this.Uzk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Uzsakymas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox Pasirinkimas;
        private ComboBox pirkejas;
        private ComboBox pardavejas;
        private TextBox Kiekis;
        private Label Be;
        private Label PVM;
        private Label preksum;
        private Label bendr;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView Uzsakymas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}