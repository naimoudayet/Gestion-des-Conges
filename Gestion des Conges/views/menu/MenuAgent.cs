using Gestion_des_Conges.config;
using Gestion_des_Conges.views.conge;
using Gestion_des_Conges.views.solde;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_Conges.views
{
    public partial class MenuAgent : Form
    {
        public MenuAgent()
        {
            InitializeComponent();
        }

        private void btnDemandeConge_Click(object sender, EventArgs e)
        {
            new CongeAdd().Show();
            this.Hide();
        }

        private void btnMesDemandes_Click(object sender, EventArgs e)
        {
            new GestionConge().Show();
            this.Hide();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            SharedPrefs.globalUser = null;

            new Authentification().Show();
            this.Hide();
        }

        private void btnMonSolde_Click(object sender, EventArgs e)
        {
            new GestionSolde().Show();
            this.Hide();
        }
    }
}
