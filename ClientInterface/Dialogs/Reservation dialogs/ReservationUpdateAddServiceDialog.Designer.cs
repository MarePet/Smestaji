using System.Windows.Forms;

namespace ClientInterface.Dialogs.Reservation_dialogs
{
    partial class ReservationUpdateAddServiceDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsluge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnDodajUslugu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(67, 128);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(187, 22);
            this.txtCena.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena";
            // 
            // txtOpis
            // 
            this.txtOpis.Enabled = false;
            this.txtOpis.Location = new System.Drawing.Point(67, 22);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(384, 96);
            this.txtOpis.TabIndex = 1;
            this.txtOpis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opis";
            // 
            // cbUsluge
            // 
            this.cbUsluge.FormattingEnabled = true;
            this.cbUsluge.Location = new System.Drawing.Point(85, 10);
            this.cbUsluge.Name = "cbUsluge";
            this.cbUsluge.Size = new System.Drawing.Size(187, 24);
            this.cbUsluge.TabIndex = 6;
            this.cbUsluge.SelectedIndexChanged += new System.EventHandler(this.cbUsluge_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usluga";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(376, 219);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(99, 50);
            this.btnNazad.TabIndex = 9;
            this.btnNazad.Text = "Povratak";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnDodajUslugu
            // 
            this.btnDodajUslugu.Location = new System.Drawing.Point(12, 219);
            this.btnDodajUslugu.Name = "btnDodajUslugu";
            this.btnDodajUslugu.Size = new System.Drawing.Size(99, 50);
            this.btnDodajUslugu.TabIndex = 8;
            this.btnDodajUslugu.Text = "Dodaj uslugu";
            this.btnDodajUslugu.UseVisualStyleBackColor = true;
            this.btnDodajUslugu.Click += new System.EventHandler(this.btnDodajUslugu_Click);
            // 
            // ReservationUpdateAddServiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbUsluge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnDodajUslugu);
            this.Name = "ReservationUpdateAddServiceDialog";
            this.Text = "ReservationUpdateAddServiceDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUsluge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnDodajUslugu;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public RichTextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbUsluge { get => cbUsluge; set => cbUsluge = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnDodajUslugu { get => btnDodajUslugu; set => btnDodajUslugu = value; }
    }
}