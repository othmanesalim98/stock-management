namespace WindowsFormsgestionstock
{
    partial class Ajoutercommande
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Num_cmd = new System.Windows.Forms.TextBox();
            this.text_id_four = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.textBox_numachat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_ID_mag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_ID_art = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_ID_cat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_qtte_achats = new System.Windows.Forms.TextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 191);
            this.dataGridView1.TabIndex = 35;
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(599, 103);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(100, 23);
            this.suprimer.TabIndex = 34;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(599, 59);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 23);
            this.modifier.TabIndex = 33;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Num Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID_fournisseur";
            // 
            // text_Num_cmd
            // 
            this.text_Num_cmd.Location = new System.Drawing.Point(128, 52);
            this.text_Num_cmd.Name = "text_Num_cmd";
            this.text_Num_cmd.Size = new System.Drawing.Size(124, 20);
            this.text_Num_cmd.TabIndex = 30;
            // 
            // text_id_four
            // 
            this.text_id_four.Location = new System.Drawing.Point(128, 91);
            this.text_id_four.Name = "text_id_four";
            this.text_id_four.Size = new System.Drawing.Size(124, 20);
            this.text_id_four.TabIndex = 29;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(599, 14);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 23);
            this.ajouter.TabIndex = 28;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // textBox_numachat
            // 
            this.textBox_numachat.Location = new System.Drawing.Point(128, 135);
            this.textBox_numachat.Name = "textBox_numachat";
            this.textBox_numachat.Size = new System.Drawing.Size(124, 20);
            this.textBox_numachat.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Num achat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ID Magasin";
            // 
            // text_ID_mag
            // 
            this.text_ID_mag.Location = new System.Drawing.Point(128, 249);
            this.text_ID_mag.Name = "text_ID_mag";
            this.text_ID_mag.Size = new System.Drawing.Size(124, 20);
            this.text_ID_mag.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Article";
            // 
            // text_ID_art
            // 
            this.text_ID_art.Location = new System.Drawing.Point(128, 170);
            this.text_ID_art.Name = "text_ID_art";
            this.text_ID_art.Size = new System.Drawing.Size(124, 20);
            this.text_ID_art.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID Categorie";
            // 
            // text_ID_cat
            // 
            this.text_ID_cat.Location = new System.Drawing.Point(128, 205);
            this.text_ID_cat.Name = "text_ID_cat";
            this.text_ID_cat.Size = new System.Drawing.Size(124, 20);
            this.text_ID_cat.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "qtte achats";
            // 
            // textBox_qtte_achats
            // 
            this.textBox_qtte_achats.Location = new System.Drawing.Point(128, 298);
            this.textBox_qtte_achats.Name = "textBox_qtte_achats";
            this.textBox_qtte_achats.Size = new System.Drawing.Size(124, 20);
            this.textBox_qtte_achats.TabIndex = 44;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(760, 393);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 46;
            this.btn_recherche.Text = "Recherche";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Num_cmd",
            "ID_four",
            "c.Num_achat",
            "ID_art",
            "ID_cat",
            "ID_mag"});
            this.comboBox1.Location = new System.Drawing.Point(392, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Enabled = false;
            this.textBox_recherche.Location = new System.Drawing.Point(562, 393);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(124, 20);
            this.textBox_recherche.TabIndex = 49;
            // 
            // Ajoutercommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 469);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_qtte_achats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_ID_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_ID_art);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_ID_mag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_numachat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Num_cmd);
            this.Controls.Add(this.text_id_four);
            this.Controls.Add(this.ajouter);
            this.Name = "Ajoutercommande";
            this.Text = "Ajoutercommande";
            this.Load += new System.EventHandler(this.Ajoutercommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Num_cmd;
        private System.Windows.Forms.TextBox text_id_four;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox textBox_numachat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_ID_mag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ID_art;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_ID_cat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_qtte_achats;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_recherche;
    }
}