using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsgestionstock
{
    public partial class AjouterArticle : Form
    {
        public AjouterArticle()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Program.remplirgridview(" select ID_art,a.ID_mag,design_mgs,a.ID_cat,design_cat,qtte_min,qtte_stock from article a join magasin m on m.ID_mag=a.ID_mag join categories c on  a.ID_cat=c.ID_cat ");
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string test = "insert into article values ("+text_ID_art.Text+",'"+text_ID_mag.Text+"','"+text_ID_cat.Text+"',"+text_qttemin.Text+","+text_qttestock.Text+")";
            Program.execute_req(test);
            dataGridView1.DataSource = Program.remplirgridview("select * from article");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string req = "update article set id_mag ='"+text_ID_mag.Text+"', id_cat='"+text_ID_cat.Text+"',qtte_min="+text_qttemin.Text+",qtte_stock="+text_qttestock.Text+" where ID_art= '"+text_ID_art.Text+"'";
            Program.execute_req(req);
            dataGridView1.DataSource = Program.remplirgridview("select * from article");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rq = "delete article where ID_art=" + text_ID_art.Text+ "";
            Program.execute_req(rq);
            dataGridView1.DataSource = Program.remplirgridview("select * from article");
        }

        private void text_ID_art_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text_ID_cat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            { MessageBox.Show("vous devez selectionner un champ "); }

            else if (string.IsNullOrWhiteSpace(textBox_recherche.Text) || string.IsNullOrEmpty(textBox_recherche.Text))
            {
                dataGridView1.DataSource = Program.remplirgridview(" select ID_art,a.ID_mag,design_mgs,a.ID_cat,design_cat,qtte_min,qtte_stock from article a join magasin m on m.ID_mag=a.ID_mag join categories c on  a.ID_cat=c.ID_cat ");


            }

            else if (comboBox1.Text != "" || textBox_recherche.Text != "")
            {
                dataGridView1.DataSource = Program.remplirgridview("select ID_art,a.ID_mag,design_mgs,a.ID_cat,design_cat,qtte_min,qtte_stock from article a join magasin m on m.ID_mag=a.ID_mag join categories c on  a.ID_cat=c.ID_cat  where " + comboBox1.Text + " ='" + textBox_recherche.Text + "'");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                textBox_recherche.Enabled = true;
            }
        }
    }
}
