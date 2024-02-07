namespace ClientInterface
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNovogKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziKlijenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPodatakaKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otkazivanjeRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem,
            this.rezervacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNovogKlijentaToolStripMenuItem,
            this.pretraziKlijenteToolStripMenuItem,
            this.izmenaPodatakaKlijenataToolStripMenuItem,
            this.brisanjeKlijentaToolStripMenuItem});
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.klijentToolStripMenuItem.Text = "Klijent";
            // 
            // kreirajNovogKlijentaToolStripMenuItem
            // 
            this.kreirajNovogKlijentaToolStripMenuItem.Name = "kreirajNovogKlijentaToolStripMenuItem";
            this.kreirajNovogKlijentaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.kreirajNovogKlijentaToolStripMenuItem.Text = "Unos novog klijenta";
            this.kreirajNovogKlijentaToolStripMenuItem.Click += new System.EventHandler(this.kreirajNovogKlijentaToolStripMenuItem_Click);
            // 
            // pretraziKlijenteToolStripMenuItem
            // 
            this.pretraziKlijenteToolStripMenuItem.Name = "pretraziKlijenteToolStripMenuItem";
            this.pretraziKlijenteToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.pretraziKlijenteToolStripMenuItem.Text = "Pretraga klijenata";
            this.pretraziKlijenteToolStripMenuItem.Click += new System.EventHandler(this.pretraziKlijenteToolStripMenuItem_Click);
            // 
            // izmenaPodatakaKlijenataToolStripMenuItem
            // 
            this.izmenaPodatakaKlijenataToolStripMenuItem.Name = "izmenaPodatakaKlijenataToolStripMenuItem";
            this.izmenaPodatakaKlijenataToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.izmenaPodatakaKlijenataToolStripMenuItem.Text = "Izmena podataka klijenata";
            this.izmenaPodatakaKlijenataToolStripMenuItem.Click += new System.EventHandler(this.izmenaPodatakaKlijenataToolStripMenuItem_Click);
            // 
            // brisanjeKlijentaToolStripMenuItem
            // 
            this.brisanjeKlijentaToolStripMenuItem.Name = "brisanjeKlijentaToolStripMenuItem";
            this.brisanjeKlijentaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.brisanjeKlijentaToolStripMenuItem.Text = "Brisanje klijenta";
            this.brisanjeKlijentaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeKlijentaToolStripMenuItem_Click);
            // 
            // rezervacijaToolStripMenuItem
            // 
            this.rezervacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajRezervacijuToolStripMenuItem,
            this.pretragaRezervacijaToolStripMenuItem,
            this.izmenaRezervacijeToolStripMenuItem,
            this.otkazivanjeRezervacijeToolStripMenuItem});
            this.rezervacijaToolStripMenuItem.Name = "rezervacijaToolStripMenuItem";
            this.rezervacijaToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.rezervacijaToolStripMenuItem.Text = "Rezervacija";
            // 
            // kreirajRezervacijuToolStripMenuItem
            // 
            this.kreirajRezervacijuToolStripMenuItem.Name = "kreirajRezervacijuToolStripMenuItem";
            this.kreirajRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.kreirajRezervacijuToolStripMenuItem.Text = "Kreiraj rezervaciju";
            this.kreirajRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.kreirajRezervacijuToolStripMenuItem_Click);
            // 
            // pretragaRezervacijaToolStripMenuItem
            // 
            this.pretragaRezervacijaToolStripMenuItem.Name = "pretragaRezervacijaToolStripMenuItem";
            this.pretragaRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.pretragaRezervacijaToolStripMenuItem.Text = "Pretraga rezervacija";
            this.pretragaRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.pretragaRezervacijaToolStripMenuItem_Click);
            // 
            // izmenaRezervacijeToolStripMenuItem
            // 
            this.izmenaRezervacijeToolStripMenuItem.Name = "izmenaRezervacijeToolStripMenuItem";
            this.izmenaRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.izmenaRezervacijeToolStripMenuItem.Text = "Izmena rezervacije";
            this.izmenaRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.izmenaRezervacijeToolStripMenuItem_Click);
            // 
            // otkazivanjeRezervacijeToolStripMenuItem
            // 
            this.otkazivanjeRezervacijeToolStripMenuItem.Name = "otkazivanjeRezervacijeToolStripMenuItem";
            this.otkazivanjeRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.otkazivanjeRezervacijeToolStripMenuItem.Text = "Otkazivanje rezervacije";
            this.otkazivanjeRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.otkazivanjeRezervacijeToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 420);
            this.pnlMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Korisnički interfejs - Smeštaji";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNovogKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziKlijenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPodatakaKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeKlijentaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem rezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otkazivanjeRezervacijeToolStripMenuItem;
    }
}