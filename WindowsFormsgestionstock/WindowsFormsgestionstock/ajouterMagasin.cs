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
    public partial class ajouterMagasin : Form
    {
        public ajouterMagasin()
        {
            InitializeComponent();
        }

        private void ajouterMagasin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.remplirgridview("select * from magasin");

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string test = "insert into magasin values ('" + text_ID_mag.Text + "','"+ text_design_mgs.Text+"')";
            Program.execute_req(test);
            dataGridView1.DataSource = Program.remplirgridview("select * from magasin");
            
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string req = "update magasin set  design_mgs='" + text_design_mgs.Text + "' where id_mag ='" + text_ID_mag.Text + "'";
            Program.execute_req(req);
            dataGridView1.DataSource = Program.remplirgridview("select * from magasin");
        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            string rq = "delete magasin where ID_art=" + text_ID_mag.Text + "";
            Program.execute_req(rq);
            dataGridView1.DataSource = Program.remplirgridview("select * from magasin");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
