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
    public partial class Ajoutercommande : Form
    {
        public Ajoutercommande()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string tesst = "insert into achats values ('" + textBox_numachat.Text + "','" + text_ID_art.Text + "','" + text_ID_cat.Text + "','" + text_ID_mag.Text + "','" + textBox_qtte_achats.Text + "')";
            Program.execute_req(tesst);
            string test = "insert into commande_achats values ('" + text_Num_cmd.Text + "','" + text_id_four.Text + "','" + textBox_numachat.Text + "')";
            Program.execute_req(test);

            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_four,c.Num_achat,ID_art,ID_cat,ID_mag,qtte from commande_achats c join  achats a on c.Num_achat=a.Num_achat ");
        }

        private void Ajoutercommande_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_four,c.Num_achat,ID_art,ID_cat,ID_mag,qtte from commande_achats c join  achats a on c.Num_achat=a.Num_achat");
         
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string req = "update achats set  ID_art='" + text_ID_art.Text + "',ID_cat='" + text_ID_cat.Text + "',ID_mag='" + text_ID_mag.Text + "',qtte='" + textBox_qtte_achats.Text + "' where Num_achat ='" + textBox_numachat.Text + "'";
            Program.execute_req(req);
            string reeq = "update commande_achats set  ID_four='" + text_id_four.Text + "',Num_achat='" + textBox_numachat.Text + "' where Num_cmd ='" + text_Num_cmd.Text + "'";
            Program.execute_req(reeq);
            dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_four,c.Num_achat,ID_art,ID_cat,ID_mag,qtte from commande_achats c join  achats a on c.Num_achat=a.Num_achat ");
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {   
            if (comboBox1.Text == "")
            { MessageBox.Show("vous devez selectionner un champ "); }
            
          else if (string.IsNullOrWhiteSpace(textBox_recherche.Text) || string.IsNullOrEmpty(textBox_recherche.Text))
            {
                dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_four,c.Num_achat,ID_art,ID_cat,ID_mag,qtte from commande_achats c join  achats a on c.Num_achat=a.Num_achat");

             
            }  
         
         else   if (comboBox1.Text != "" || textBox_recherche.Text!="" )
            {
                dataGridView1.DataSource = Program.remplirgridview("select Num_cmd,ID_four,c.Num_achat,ID_art,ID_cat,ID_mag,qtte from commande_achats c join  achats a on c.Num_achat=a.Num_achat where " + comboBox1.Text + " ='" + textBox_recherche.Text + "'");
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
