namespace WindowsFormsgestionstock
{
    partial class ajouterMagasin
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
            this.text_ID_mag = new System.Windows.Forms.TextBox();
            this.text_design_mgs = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 179);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(579, 105);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(100, 23);
            this.suprimer.TabIndex = 26;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(579, 61);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(100, 23);
            this.modifier.TabIndex = 25;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID Magasin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "design Magasin";
            // 
            // text_ID_mag
            // 
            this.text_ID_mag.Location = new System.Drawing.Point(108, 54);
            this.text_ID_mag.Name = "text_ID_mag";
            this.text_ID_mag.Size = new System.Drawing.Size(124, 20);
            this.text_ID_mag.TabIndex = 16;
            // 
            // text_design_mgs
            // 
            this.text_design_mgs.Location = new System.Drawing.Point(108, 93);
            this.text_design_mgs.Name = "text_design_mgs";
            this.text_design_mgs.Size = new System.Drawing.Size(124, 20);
            this.text_design_mgs.TabIndex = 15;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(579, 16);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 23);
            this.ajouter.TabIndex = 14;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // ajouterMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_ID_mag);
            this.Controls.Add(this.text_design_mgs);
            this.Controls.Add(this.ajouter);
            this.Name = "ajouterMagasin";
            this.Text = "ajouterMagasin";
            this.Load += new System.EventHandler(this.ajouterMagasin_Load);
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
        private System.Windows.Forms.TextBox text_ID_mag;
        private System.Windows.Forms.TextBox text_design_mgs;
        private System.Windows.Forms.Button ajouter;
    }
}