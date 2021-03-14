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
    public partial class AgentAdd : Form
    {
        public AgentAdd()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = tbName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;
            string cPassword = tbConfirmPassword.Text;

            if(validateFormData(user))
            {
                new UserController().create(user);

                MessageBox.Show("agent ajouter");
                navigateTo();
            }
        }

        private bool validateFormData(User user)
        {
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigateTo();
        }

        private void navigateTo()
        {
            new GestionDesAgents().Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            tbName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
        }
    }
}
