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
    public partial class commande_ventes : Form
    {
        public commande_ventes()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            string tesst = " insert into ventes values ('" + textBox_numventes.Text + "','" + text_ID_art.Text + "','" + text_ID_cat.Text + "','" + text_ID_mag.Text + "','" + textBox_qtte_ventes.Text + "') begin tran  begin try '"+text_ID_art.Text+"'  in (select ID_art from article )  ";
               Program.execute_req(tesst);
               //string tot = string.Format("if (@check= 0) begin '" + MessageBox.Show("fffr") + "'end ");
              
              
               //Program.exctt(tot);
            string test = "insert into commande_ventes values ('" + text_Num_cmd.Text + "','" + text_ID_client.Text + "','" + textBox_numventes.Text + "')";
            Program.execute_req(test);

            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes ");
        }
        

        private void commande_ventes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                textBox_recherche.Enabled = true;
            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            { MessageBox.Show("vous devez selectionner un champ "); }

            else if (string.IsNullOrWhiteSpace(textBox_recherche.Text) || string.IsNullOrEmpty(textBox_recherche.Text))
            {
                dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes");


            }

            else if (comboBox1.Text != "" || textBox_recherche.Text != "")
            {
                dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes where " + comboBox1.Text + " ='" + textBox_recherche.Text + "'");
            }
             
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string req = "update ventes set  ID_art='" + text_ID_art.Text + "',ID_cat='" + text_ID_cat.Text + "',ID_mag='" + text_ID_mag.Text + "',qtte='" + textBox_qtte_ventes.Text + "' where Num_ventes ='" + textBox_numventes.Text + "'";
            Program.execute_req(req);
            string reeq = "update commande_ventes set  ID_client='" + text_ID_client.Text + "',Num_ventes='" + textBox_numventes.Text + "' where Num_cmd ='" + text_Num_cmd.Text + "'";
            Program.execute_req(reeq);
            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes ");
        }

        private void suprimer_Click(object sender, EventArgs e)
        {

        }
        
    }
}
