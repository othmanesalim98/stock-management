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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Ajoutercommande commande = new Ajoutercommande();
            commande.Show();
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterArticle article = new AjouterArticle();
            article.Show();
        }

        private void magasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterMagasin magasin = new ajouterMagasin();
            magasin.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fournisseur Fournisseur = new Fournisseur();
            Fournisseur.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void commandeDeVentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commande_ventes command = new commande_ventes();
            command.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients client = new clients();
            client.Show();
        }
    }
}
