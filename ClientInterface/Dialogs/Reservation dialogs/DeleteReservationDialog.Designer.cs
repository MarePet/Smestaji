using System.Windows.Forms;

namespace ClientInterface.Dialogs.Reservation_dialogs
{
    partial class DeleteReservationDialog
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
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsluge);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 205);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usluge";
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(7, 22);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(508, 177);
            this.dgvUsluge.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ukupna cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj dana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Klijent";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Location = new System.Drawing.Point(113, 89);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(64, 22);
            this.txtUkupnaCena.TabIndex = 15;
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(113, 49);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(64, 22);
            this.txtBrojDana.TabIndex = 14;
            // 
            // txtKlijent
            // 
            this.txtKlijent.Enabled = false;
            this.txtKlijent.Location = new System.Drawing.Point(113, 9);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(209, 22);
            this.txtKlijent.TabIndex = 13;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(10, 340);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(119, 39);
            this.btnPovratak.TabIndex = 12;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Obriši rezervaciju";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteReservationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 403);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.txtBrojDana);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.btnPovratak);
            this.Name = "DeleteReservationDialog";
            this.Text = "DeleteReservationDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteReservationDialog_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDelete;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public DataGridView DgvUsluge { get => dgvUsluge; set => dgvUsluge = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtUkupnaCena { get => txtUkupnaCena; set => txtUkupnaCena = value; }
        public TextBox TxtBrojDana { get => txtBrojDana; set => txtBrojDana = value; }
        public TextBox TxtKlijent { get => txtKlijent; set => txtKlijent = value; }
        public Button BtnPovratak { get => btnPovratak; set => btnPovratak = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
    }
}