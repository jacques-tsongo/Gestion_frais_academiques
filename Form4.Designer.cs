namespace gestioin_frais_academiques
{
    partial class addPaiement
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
            this.ajouterUnPaiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLhistoriqueDesPaiementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_contents = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnPaiementToolStripMenuItem,
            this.voirLhistoriqueDesPaiementsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterUnPaiementToolStripMenuItem
            // 
            this.ajouterUnPaiementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterUnPaiementToolStripMenuItem.Name = "ajouterUnPaiementToolStripMenuItem";
            this.ajouterUnPaiementToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.ajouterUnPaiementToolStripMenuItem.Text = "Ajouter un paiement";
            this.ajouterUnPaiementToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnPaiementToolStripMenuItem_Click);
            // 
            // voirLhistoriqueDesPaiementsToolStripMenuItem
            // 
            this.voirLhistoriqueDesPaiementsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voirLhistoriqueDesPaiementsToolStripMenuItem.Name = "voirLhistoriqueDesPaiementsToolStripMenuItem";
            this.voirLhistoriqueDesPaiementsToolStripMenuItem.Size = new System.Drawing.Size(287, 29);
            this.voirLhistoriqueDesPaiementsToolStripMenuItem.Text = "Voir l\'historique des paiements";
            this.voirLhistoriqueDesPaiementsToolStripMenuItem.Click += new System.EventHandler(this.voirLhistoriqueDesPaiementsToolStripMenuItem_Click);
            // 
            // main_contents
            // 
            this.main_contents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_contents.Location = new System.Drawing.Point(0, 36);
            this.main_contents.Name = "main_contents";
            this.main_contents.Size = new System.Drawing.Size(784, 524);
            this.main_contents.TabIndex = 1;
            // 
            // addPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.main_contents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "addPaiement";
            this.Text = "Ajout des paiements";
            this.Load += new System.EventHandler(this.addPaiement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnPaiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLhistoriqueDesPaiementsToolStripMenuItem;
        private System.Windows.Forms.Panel main_contents;
    }
}