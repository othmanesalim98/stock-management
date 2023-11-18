namespace WindowsFormsgestionstock
{
    partial class AjouterArticle
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
            this.ajouter = new System.Windows.Forms.Button();
            this.text_ID_art = new System.Windows.Forms.TextBox();
            this.text_ID_mag = new System.Windows.Forms.TextBox();
            this.text_ID_cat = new System.Windows.Forms.TextBox();
            this.text_qttemin = new System.Windows.Forms.TextBox();
            this.text_qttestock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.suprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(572, 34);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 23);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_ID_art
            // 
            this.text_ID_art.Location = new System.Drawing.Point(101, 34);
            this.text_ID_art.Name = "text_ID_art";
            this.text_ID_art.Size = new System.Drawing.Size(124, 20);
            this.text_ID_art.TabIndex = 1;
            this.text_ID_art.TextChanged += new System.EventHandler(this.text_ID_art_TextChanged);
            // 
            // text_ID_mag
            // 
            this.text_ID_mag.Location = new System.Drawing.Point(101, 72);
            this.text_ID_mag.Name = "text_ID_mag";
            this.text_ID_mag.Size = new System.Drawing.Size(124, 20);
            this.text_ID_mag.TabIndex = 2;
            // 
            // text_ID_cat
            // 
            this.text_ID_cat.Location = new System.Drawing.Point(101, 116);
            this.text_ID_cat.Name = "text_ID_cat";
            this.text_ID_cat.Size = new System.Drawing.Size(124, 20);
            this.text_ID_cat.TabIndex = 3;
            this.text_ID_cat.TextChanged += new System.EventHandler(this.text_ID_cat_TextChanged);
            // 
            // text_qttemin
            // 
            this.text_qttemin.Location = new System.Drawing.Point(101, 164);
            this.text_qttemin.Name = "text_qttemin";
            this.text_qttemin.Size = new System.Drawing.Size(124, 20);
            this.text_qttemin.TabIndex = 4;
            // 
            // text_qttestock
            // 
            this.text_qttestock.Location = new System.Drawing.Point(101, 206);
            this.text_qttestock.Name = "text_qttestock";
            this.text_qttestock.Size = new System.Drawing.Size(124, 20);
            this.text_qttestock.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Magasin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Categorie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qtte min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtte stock";
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(572, 79);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 23);
            this.modifier.TabIndex = 11;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(572, 123);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(100, 23);
            this.suprimer.TabIndex = 12;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 179);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Enabled = false;
            this.textBox_recherche.Location = new System.Drawing.Point(548, 378);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(124, 20);
            this.textBox_recherche.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID_art",
            "a.ID_mag",
            "design_mgs",
            "a.ID_cat",
            "design_cat"});
            this.comboBox1.Location = new System.Drawing.Point(377, 377);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(746, 378);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 50;
            this.btn_recherche.Text = "Recherche";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // AjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 432);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_qttestock);
            this.Controls.Add(this.text_qttemin);
            this.Controls.Add(this.text_ID_cat);
            this.Controls.Add(this.text_ID_mag);
            this.Controls.Add(this.text_ID_art);
            this.Controls.Add(this.ajouter);
            this.Name = "AjouterArticle";
            this.Text = "Ajouter Article";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox text_ID_art;
        private System.Windows.Forms.TextBox text_ID_mag;
        private System.Windows.Forms.TextBox text_ID_cat;
        private System.Windows.Forms.TextBox text_qttemin;
        private System.Windows.Forms.TextBox text_qttestock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_recherche;
    }
}