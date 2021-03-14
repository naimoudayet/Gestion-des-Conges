using Gestion_des_Conges.config;
using Gestion_des_Conges.controller;
using Gestion_des_Conges.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_Conges.views.solde
{
    public partial class GestionSolde : Form
    {
        UserController userController;
        CongeController congeController;

        List<User> users;

        public GestionSolde()
        {
            userController = new UserController();
            congeController = new CongeController();

            InitializeComponent();

            users = userController.readAll();
            initComboBoxAgent(users);

            tbSolde.Enabled = false;
        }

        private void initComboBoxAgent(List<User> users)
        {
            foreach (User u in users)
            {
                cbAgent.Items.Add(u.Name);
            }

            if (SharedPrefs.globalUser.Role.Equals("AGENT"))
            {
                cbAgent.SelectedItem = SharedPrefs.globalUser.Name;
                cbAgent.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (SharedPrefs.globalUser.Role == "ADMIN")
            {
                new MenuAdministrateur().Show();
                this.Hide();
            }
            else
            {
                new MenuAgent().Show();
                this.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                User user = users[cbAgent.SelectedIndex];

                tbSolde.Text = Convert.ToString(congeController.solde(user.ID));
                 
            }
            catch (Exception error)
            {
                MessageBox.Show("svp, choisir un agent ?");
            }
        }
    }
}
