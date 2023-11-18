namespace WindowsFormsgestionstock
{
    partial class commande_ventes
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
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_qtte_ventes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_ID_cat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_ID_art = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_ID_mag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_numventes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Num_cmd = new System.Windows.Forms.TextBox();
            this.text_ID_client = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Enabled = false;
            this.textBox_recherche.Location = new System.Drawing.Point(6, 28);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(124, 20);
            this.textBox_recherche.TabIndex = 70;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Num_cmd",
            "ID_client",
            "c.Num_ventes",
            "ID_art",
            "ID_cat",
            "ID_mag"});
            this.comboBox1.Location = new System.Drawing.Point(9, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(136, 41);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 68;
            this.btn_recherche.Text = "Recherche";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "qtte vendue";
            // 
            // textBox_qtte_ventes
            // 
            this.textBox_qtte_ventes.Location = new System.Drawing.Point(105, 244);
            this.textBox_qtte_ventes.Name = "textBox_qtte_ventes";
            this.textBox_qtte_ventes.Size = new System.Drawing.Size(124, 20);
            this.textBox_qtte_ventes.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "ID Categorie";
            // 
            // text_ID_cat
            // 
            this.text_ID_cat.Location = new System.Drawing.Point(105, 163);
            this.text_ID_cat.Name = "text_ID_cat";
            this.text_ID_cat.Size = new System.Drawing.Size(124, 20);
            this.text_ID_cat.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "ID Article";
            // 
            // text_ID_art
            // 
            this.text_ID_art.Location = new System.Drawing.Point(105, 128);
            this.text_ID_art.Name = "text_ID_art";
            this.text_ID_art.Size = new System.Drawing.Size(124, 20);
            this.text_ID_art.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "ID Magasin";
            // 
            // text_ID_mag
            // 
            this.text_ID_mag.Location = new System.Drawing.Point(105, 202);
            this.text_ID_mag.Name = "text_ID_mag";
            this.text_ID_mag.Size = new System.Drawing.Size(124, 20);
            this.text_ID_mag.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Num ventes";
            // 
            // textBox_numventes
            // 
            this.textBox_numventes.Location = new System.Drawing.Point(105, 90);
            this.textBox_numventes.Name = "textBox_numventes";
            this.textBox_numventes.Size = new System.Drawing.Size(124, 20);
            this.textBox_numventes.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 191);
            this.dataGridView1.TabIndex = 57;
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(520, 162);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(100, 23);
            this.suprimer.TabIndex = 56;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(520, 118);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 23);
            this.modifier.TabIndex = 55;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Num Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID_client";
            // 
            // text_Num_cmd
            // 
            this.text_Num_cmd.Location = new System.Drawing.Point(105, 10);
            this.text_Num_cmd.Name = "text_Num_cmd";
            this.text_Num_cmd.Size = new System.Drawing.Size(124, 20);
            this.text_Num_cmd.TabIndex = 52;
            // 
            // text_ID_client
            // 
            this.text_ID_client.Location = new System.Drawing.Point(105, 49);
            this.text_ID_client.Name = "text_ID_client";
            this.text_ID_client.Size = new System.Drawing.Size(124, 20);
            this.text_ID_client.TabIndex = 51;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(520, 73);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 23);
            this.ajouter.TabIndex = 50;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // Recherche
            // 
            this.Recherche.Controls.Add(this.textBox_recherche);
            this.Recherche.Controls.Add(this.btn_recherche);
            this.Recherche.Controls.Add(this.comboBox1);
            this.Recherche.Location = new System.Drawing.Point(861, 174);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(229, 100);
            this.Recherche.TabIndex = 71;
            this.Recherche.TabStop = false;
            this.Recherche.Text = "Recherche";
            // 
            // commande_ventes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 473);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_qtte_ventes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_ID_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_ID_art);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_ID_mag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_numventes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Num_cmd);
            this.Controls.Add(this.text_ID_client);
            this.Controls.Add(this.ajouter);
            this.Name = "commande_ventes";
            this.Text = "commande_ventes";
            this.Load += new System.EventHandler(this.commande_ventes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Recherche.ResumeLayout(false);
            this.Recherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_qtte_ventes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_ID_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ID_art;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_ID_mag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_numventes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Num_cmd;
        private System.Windows.Forms.TextBox text_ID_client;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.GroupBox Recherche;
    }
}