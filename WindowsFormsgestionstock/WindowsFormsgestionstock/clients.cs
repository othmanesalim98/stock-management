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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        private void clients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.remplirgridview("select * from clients");
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string test = "insert into clients values ('" + text_ID_client.Text + "','" + text_design_client.Text + "','" + textBox_ville.Text + "')";
            Program.execute_req(test);
            dataGridView1.DataSource = Program.remplirgridview("select * from clients");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string req = "update clients set  design_client='" + text_design_client.Text + "','" + textBox_ville.Text + "' where ID_client ='" + text_ID_client.Text + "'";
            Program.execute_req(req);
            dataGridView1.DataSource = Program.remplirgridview("select * from clients");
        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            string rq = "delete clients where ID_four=" + text_ID_client.Text + "";
            Program.execute_req(rq);
            dataGridView1.DataSource = Program.remplirgridview("select * from clients");
        }
    }
}
