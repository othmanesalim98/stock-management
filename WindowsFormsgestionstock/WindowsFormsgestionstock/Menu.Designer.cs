namespace WindowsFormsgestionstock
{
    partial class Menu
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
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeDeVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magasinToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.articleToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.commandeDeVentesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // magasinToolStripMenuItem
            // 
            this.magasinToolStripMenuItem.Name = "magasinToolStripMenuItem";
            this.magasinToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.magasinToolStripMenuItem.Text = "Magasin";
            this.magasinToolStripMenuItem.Click += new System.EventHandler(this.magasinToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.articleToolStripMenuItem.Text = "Article";
            this.articleToolStripMenuItem.Click += new System.EventHandler(this.articleToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.commandToolStripMenuItem.Text = "Commande d\'achats";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // commandeDeVentesToolStripMenuItem
            // 
            this.commandeDeVentesToolStripMenuItem.Name = "commandeDeVentesToolStripMenuItem";
            this.commandeDeVentesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.commandeDeVentesToolStripMenuItem.Text = "Commande de ventes";
            this.commandeDeVentesToolStripMenuItem.Click += new System.EventHandler(this.commandeDeVentesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magasinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeDeVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    }
}

