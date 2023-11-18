namespace WindowsFormsgestionstock
{
    partial class Fournisseur
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
            this.text_ID_four = new System.Windows.Forms.TextBox();
            this.text_design_four = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 179);
            this.dataGridView1.TabIndex = 35;
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(665, 105);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(100, 23);
            this.suprimer.TabIndex = 34;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(665, 61);
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
            this.label2.Location = new System.Drawing.Point(67, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "design Fournisseur";
            // 
            // text_ID_four
            // 
            this.text_ID_four.Location = new System.Drawing.Point(169, 37);
            this.text_ID_four.Name = "text_ID_four";
            this.text_ID_four.Size = new System.Drawing.Size(124, 20);
            this.text_ID_four.TabIndex = 30;
            // 
            // text_design_four
            // 
            this.text_design_four.Location = new System.Drawing.Point(169, 72);
            this.text_design_four.Name = "text_design_four";
            this.text_design_four.Size = new System.Drawing.Size(124, 20);
            this.text_design_four.TabIndex = 29;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(665, 16);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 23);
            this.ajouter.TabIndex = 28;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ville";
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(169, 109);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(124, 20);
            this.textBox_ville.TabIndex = 36;
            // 
            // Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_ID_four);
            this.Controls.Add(this.text_design_four);
            this.Controls.Add(this.ajouter);
            this.Name = "Fournisseur";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.Fournisseur_Load);
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
        private System.Windows.Forms.TextBox text_ID_four;
        private System.Windows.Forms.TextBox text_design_four;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ville;
    }
}