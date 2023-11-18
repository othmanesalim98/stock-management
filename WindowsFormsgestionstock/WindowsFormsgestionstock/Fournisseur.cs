using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsgestionstock
{
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string test = "insert into fournisseur values ('" + text_ID_four.Text + "','" + text_design_four.Text + "','" + textBox_ville.Text + "')";
            Program.execute_req(test);
            dataGridView1.DataSource = Program.remplirgridview("select * from fournisseur");
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.remplirgridview("select * from fournisseur");

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string req = "update fournisseur set  design_four='" + text_design_four.Text + "',ville='" + textBox_ville.Text + "' where ID_four ='" + text_ID_four.Text + "' ";
            Program.execute_req(req);
            dataGridView1.DataSource = Program.remplirgridview("select * from fournisseur");
        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            
                string rq = "delete fournisseur where ID_four=" + text_ID_four.Text + "";
                Program.execute_req(rq);
                dataGridView1.DataSource = Program.remplirgridview("select * from fournisseur");
           
        }
        
    }
}
