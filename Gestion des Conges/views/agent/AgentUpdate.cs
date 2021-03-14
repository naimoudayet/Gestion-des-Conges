using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_des_Conges.model;
using Gestion_des_Conges.controller;

namespace Gestion_des_Conges.views.agent
{
    public partial class AgentUpdate : Form
    {
        UserController userController;
        User user;

        public AgentUpdate()
        {
            userController = new UserController();

            InitializeComponent();

            user = userController.readOne(GestionDesAgents.selectedItemId);
            if (user != null)
            {
                tbID.Text = Convert.ToString(user.ID);
                tbID.Enabled = false;

                tbName.Text = user.Name;
                tbEmail.Text = user.Email;
                tbPassword.Text = user.Password;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigateTo();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.Name = tbName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;

            if (validateFormData(user))
            {
                new UserController().update(user);

                MessageBox.Show("agent modifier");
                navigateTo();
            }
        }

        private bool validateFormData(User user)
        {
            return true;
        }

        private void navigateTo()
        {
            new GestionDesAgents().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Supprimer Agent?",
                "Confirmation",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                new UserController().delete(user.ID);

                MessageBox.Show("agent supprimer");
                navigateTo();
            }
            
        }
    }
}
