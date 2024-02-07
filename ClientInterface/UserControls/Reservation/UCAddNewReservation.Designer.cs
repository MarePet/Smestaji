using System.Windows.Forms;

namespace ClientInterface.UserControls.Reservation
{
    partial class UCAddNewReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDRezervacije = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObracunaj = new System.Windows.Forms.Button();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.dpDatumKraja = new System.Windows.Forms.DateTimePicker();
            this.dpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.cbTipoviRezervacije = new System.Windows.Forms.ComboBox();
            this.cbKlijenti = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            this.btnDodajUsluge = new System.Windows.Forms.Button();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.btnKreairajRezervaciju = new System.Windows.Forms.Button();
            this.txtAdministrator = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(121, 241);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(0, 16);
            this.lblAdministrator.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdministrator);
            this.groupBox1.Controls.Add(this.txtBrojDana);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIDRezervacije);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnObracunaj);
            this.groupBox1.Controls.Add(this.txtUkupnaCena);
            this.groupBox1.Controls.Add(this.dpDatumKraja);
            this.groupBox1.Controls.Add(this.dpDatumPocetka);
            this.groupBox1.Controls.Add(this.cbTipoviRezervacije);
            this.groupBox1.Controls.Add(this.cbKlijenti);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 365);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Location = new System.Drawing.Point(118, 243);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(109, 22);
            this.txtBrojDana.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Broj dana";
            // 
            // txtIDRezervacije
            // 
            this.txtIDRezervacije.Location = new System.Drawing.Point(118, 35);
            this.txtIDRezervacije.Name = "txtIDRezervacije";
            this.txtIDRezervacije.Size = new System.Drawing.Size(109, 22);
            this.txtIDRezervacije.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID rezervacije";
            // 
            // btnObracunaj
            // 
            this.btnObracunaj.Location = new System.Drawing.Point(360, 274);
            this.btnObracunaj.Name = "btnObracunaj";
            this.btnObracunaj.Size = new System.Drawing.Size(142, 32);
            this.btnObracunaj.TabIndex = 3;
            this.btnObracunaj.Text = "Obračunaj";
            this.btnObracunaj.UseVisualStyleBackColor = true;
            this.btnObracunaj.Click += new System.EventHandler(this.btnObracunaj_Click);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Location = new System.Drawing.Point(118, 281);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(236, 22);
            this.txtUkupnaCena.TabIndex = 22;
            // 
            // dpDatumKraja
            // 
            this.dpDatumKraja.Location = new System.Drawing.Point(118, 203);
            this.dpDatumKraja.Name = "dpDatumKraja";
            this.dpDatumKraja.Size = new System.Drawing.Size(236, 22);
            this.dpDatumKraja.TabIndex = 21;
            this.dpDatumKraja.ValueChanged += new System.EventHandler(this.dpDatumKraja_ValueChanged);
            // 
            // dpDatumPocetka
            // 
            this.dpDatumPocetka.Location = new System.Drawing.Point(118, 159);
            this.dpDatumPocetka.Name = "dpDatumPocetka";
            this.dpDatumPocetka.Size = new System.Drawing.Size(236, 22);
            this.dpDatumPocetka.TabIndex = 20;
            // 
            // cbTipoviRezervacije
            // 
            this.cbTipoviRezervacije.FormattingEnabled = true;
            this.cbTipoviRezervacije.Location = new System.Drawing.Point(118, 117);
            this.cbTipoviRezervacije.Name = "cbTipoviRezervacije";
            this.cbTipoviRezervacije.Size = new System.Drawing.Size(236, 24);
            this.cbTipoviRezervacije.TabIndex = 19;
            // 
            // cbKlijenti
            // 
            this.cbKlijenti.FormattingEnabled = true;
            this.cbKlijenti.Location = new System.Drawing.Point(118, 73);
            this.cbKlijenti.Name = "cbKlijenti";
            this.cbKlijenti.Size = new System.Drawing.Size(236, 24);
            this.cbKlijenti.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Administrator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ukupna cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Datum kraja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Datum početka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tip rezervacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klijent";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiUslugu);
            this.groupBox2.Controls.Add(this.btnDodajUsluge);
            this.groupBox2.Controls.Add(this.dgvUsluge);
            this.groupBox2.Location = new System.Drawing.Point(15, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 279);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usluge";
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
            // btnKreairajRezervaciju
            // 
            this.btnKreairajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreairajRezervaciju.Location = new System.Drawing.Point(19, 672);
            this.btnKreairajRezervaciju.Name = "btnKreairajRezervaciju";
            this.btnKreairajRezervaciju.Size = new System.Drawing.Size(251, 53);
            this.btnKreairajRezervaciju.TabIndex = 3;
            this.btnKreairajRezervaciju.Text = "KREIRAJ REZERVACIJU";
            this.btnKreairajRezervaciju.UseVisualStyleBackColor = true;
            this.btnKreairajRezervaciju.Click += new System.EventHandler(this.btnKreairajRezervaciju_Click);
            // 
            // txtAdministrator
            // 
            this.txtAdministrator.AutoSize = true;
            this.txtAdministrator.Location = new System.Drawing.Point(113, 334);
            this.txtAdministrator.Name = "txtAdministrator";
            this.txtAdministrator.Size = new System.Drawing.Size(0, 16);
            this.txtAdministrator.TabIndex = 27;
            // 
            // UCAddNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKreairajRezervaciju);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdministrator);
            this.Name = "UCAddNewReservation";
            this.Size = new System.Drawing.Size(542, 745);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.DateTimePicker dpDatumKraja;
        private System.Windows.Forms.DateTimePicker dpDatumPocetka;
        private System.Windows.Forms.ComboBox cbTipoviRezervacije;
        private System.Windows.Forms.ComboBox cbKlijenti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajUsluge;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.Button btnKreairajRezervaciju;
        private Button btnObracunaj;
        private TextBox txtIDRezervacije;
        private Label label7;
        private TextBox txtBrojDana;
        private Label label8;
        private Label txtAdministrator;

        public Label LblAdministrator { get => lblAdministrator; set => lblAdministrator = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtUkupnaCena { get => txtUkupnaCena; set => txtUkupnaCena = value; }
        public DateTimePicker DpDatumKraja { get => dpDatumKraja; set => dpDatumKraja = value; }
        public DateTimePicker DpDatumPocetka { get => dpDatumPocetka; set => dpDatumPocetka = value; }
        public ComboBox CbTipoviRezervacije { get => cbTipoviRezervacije; set => cbTipoviRezervacije = value; }
        public ComboBox CbKlijenti { get => cbKlijenti; set => cbKlijenti = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public Button BtnDodajUsluge { get => btnDodajUsluge; set => btnDodajUsluge = value; }
        public DataGridView DgvUsluge { get => dgvUsluge; set => dgvUsluge = value; }
        public Button BtnObrisiUslugu { get => btnObrisiUslugu; set => btnObrisiUslugu = value; }
        public Button BtnKreairajRezervaciju { get => btnKreairajRezervaciju; set => btnKreairajRezervaciju = value; }
        public TextBox TxtIDRezervacije { get => txtIDRezervacije; set => txtIDRezervacije = value; }
        public TextBox TxtBrojDana { get => txtBrojDana; set => txtBrojDana = value; }
        public Label TxtAdministrator { get => txtAdministrator; set => txtAdministrator = value; }
    }
}
