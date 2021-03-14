using Gestion_des_Conges.config;
using Gestion_des_Conges.views.agent;
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
    public partial class MenuAdministrateur : Form
    {
        public MenuAdministrateur()
        {
            InitializeComponent();
        }

        private void btnGestionDesAgents_Click(object sender, EventArgs e)
        {
            new GestionDesAgents().Show();
            this.Hide();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            SharedPrefs.globalUser = null;

            new Authentification().Show();
            this.Hide();
        }

        private void btnGestionDesDemandes_Click(object sender, EventArgs e)
        {
            new GestionConge().Show();
            this.Hide();
        }

        private void btnSoldeAgents_Click(object sender, EventArgs e)
        {
            new GestionSolde().Show();
            this.Hide();
        }
    }
}
