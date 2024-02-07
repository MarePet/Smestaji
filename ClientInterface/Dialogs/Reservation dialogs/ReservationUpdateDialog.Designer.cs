using System.Windows.Forms;

namespace ClientInterface.Dialogs.Reservation_dialogs
{
    partial class ReservationUpdateDialog
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
            this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajUsluge = new System.Windows.Forms.Button();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.dpDatumKraja = new System.Windows.Forms.DateTimePicker();
            this.dpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.cbTipoviRezervacije = new System.Windows.Forms.ComboBox();
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObracunaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeniRezervaciju
            // 
            this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(12, 603);
            this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
            this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(251, 53);
            this.btnIzmeniRezervaciju.TabIndex = 10;
            this.btnIzmeniRezervaciju.Text = "IZMENI REZERVACIJU";
            this.btnIzmeniRezervaciju.UseVisualStyleBackColor = true;
            this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
            // 
            // btnDodajUsluge
            // 
            this.btnDodajUsluge.Location = new System.Drawing.Point(4, 217);
            this.btnDodajUsluge.Name = "btnDodajUsluge";
            this.btnDodajUsluge.Size = new System.Drawing.Size(144, 53);
            this.btnDodajUsluge.TabIndex = 1;
            this.btnDodajUsluge.Text = "Dodaj usluge";
            this.btnDodajUsluge.UseVisualStyleBackColor = true;
            this.btnDodajUsluge.Click += new System.EventHandler(this.btnDodajUsluge_Click);
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(118, 199);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(109, 22);
            this.txtBrojDana.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Broj dana";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Location = new System.Drawing.Point(118, 237);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(236, 22);
            this.txtUkupnaCena.TabIndex = 22;
            // 
            // dpDatumKraja
            // 
            this.dpDatumKraja.Location = new System.Drawing.Point(118, 159);
            this.dpDatumKraja.Name = "dpDatumKraja";
            this.dpDatumKraja.Size = new System.Drawing.Size(236, 22);
            this.dpDatumKraja.TabIndex = 21;
            this.dpDatumKraja.ValueChanged += new System.EventHandler(this.dpDatumKraja_ValueChanged);
            // 
            // dpDatumPocetka
            // 
            this.dpDatumPocetka.Location = new System.Drawing.Point(118, 115);
            this.dpDatumPocetka.Name = "dpDatumPocetka";
            this.dpDatumPocetka.Size = new System.Drawing.Size(236, 22);
            this.dpDatumPocetka.TabIndex = 20;
            // 
            // cbTipoviRezervacije
            // 
            this.cbTipoviRezervacije.FormattingEnabled = true;
            this.cbTipoviRezervacije.Location = new System.Drawing.Point(118, 73);
            this.cbTipoviRezervacije.Name = "cbTipoviRezervacije";
            this.cbTipoviRezervacije.Size = new System.Drawing.Size(236, 24);
            this.cbTipoviRezervacije.TabIndex = 19;
            // 
            // btnObrisiUslugu
            // 
            this.btnObrisiUslugu.Location = new System.Drawing.Point(164, 217);
            this.btnObrisiUslugu.Name = "btnObrisiUslugu";
            this.btnObrisiUslugu.Size = new System.Drawing.Size(144, 53);
            this.btnObrisiUslugu.TabIndex = 2;
            this.btnObrisiUslugu.Text = "Obrisi uslugu";
            this.btnObrisiUslugu.UseVisualStyleBackColor = true;
            this.btnObrisiUslugu.Click += new System.EventHandler(this.btnObrisiUslugu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiUslugu);
            this.groupBox2.Controls.Add(this.btnDodajUsluge);
            this.groupBox2.Controls.Add(this.dgvUsluge);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 279);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usluge";
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(9, 21);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(506, 190);
            this.dgvUsluge.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Datum kraja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Datum početka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tip rezervacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klijent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObracunaj);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtBrojDana);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUkupnaCena);
            this.groupBox1.Controls.Add(this.dpDatumKraja);
            this.groupBox1.Controls.Add(this.dpDatumPocetka);
            this.groupBox1.Controls.Add(this.cbTipoviRezervacije);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 300);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
            // 
            // btnObracunaj
            // 
            this.btnObracunaj.Location = new System.Drawing.Point(373, 230);
            this.btnObracunaj.Name = "btnObracunaj";
            this.btnObracunaj.Size = new System.Drawing.Size(142, 32);
            this.btnObracunaj.TabIndex = 28;
            this.btnObracunaj.Text = "Obračunaj";
            this.btnObracunaj.UseVisualStyleBackColor = true;
            this.btnObracunaj.Click += new System.EventHandler(this.btnObracunaj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(118, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ukupna cena";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(127, 250);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(0, 16);
            this.lblAdministrator.TabIndex = 11;
            // 
            // ReservationUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 675);
            this.Controls.Add(this.btnIzmeniRezervaciju);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdministrator);
            this.Name = "ReservationUpdateDialog";
            this.Text = "ReservationUpdateDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationUpdateDialog_FormClosed);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniRezervaciju;
        private System.Windows.Forms.Button btnDodajUsluge;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.DateTimePicker dpDatumKraja;
        private System.Windows.Forms.DateTimePicker dpDatumPocetka;
        private System.Windows.Forms.ComboBox cbTipoviRezervacije;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdministrator;
        private Button btnObracunaj;

        public Button BtnIzmeniRezervaciju { get => btnIzmeniRezervaciju; set => btnIzmeniRezervaciju = value; }
        public Button BtnDodajUsluge { get => btnDodajUsluge; set => btnDodajUsluge = value; }
        public TextBox TxtBrojDana { get => txtBrojDana; set => txtBrojDana = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public TextBox TxtUkupnaCena { get => txtUkupnaCena; set => txtUkupnaCena = value; }
        public DateTimePicker DpDatumKraja { get => dpDatumKraja; set => dpDatumKraja = value; }
        public DateTimePicker DpDatumPocetka { get => dpDatumPocetka; set => dpDatumPocetka = value; }
        public ComboBox CbTipoviRezervacije { get => cbTipoviRezervacije; set => cbTipoviRezervacije = value; }
        public Button BtnObrisiUslugu { get => btnObrisiUslugu; set => btnObrisiUslugu = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public DataGridView DgvUsluge { get => dgvUsluge; set => dgvUsluge = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label LblAdministrator { get => lblAdministrator; set => lblAdministrator = value; }
    }
}