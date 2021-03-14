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

namespace Gestion_des_Conges.views.conge
{
    public partial class CongeAdd : Form
    {
        UserController userController;

        List<User> users;

        public CongeAdd()
        {
            userController = new UserController();

            InitializeComponent();

            tbNbrJours.MaxLength = 3;
            tbNumTel.MaxLength = 8;

            users = userController.readAll();
            initComboBoxAgent(users);
        }

        private void initComboBoxAgent(List<User> users)
        {
            foreach(User u in users)
            {
                cbAgent.Items.Add(u.Name);
            }

            if(SharedPrefs.globalUser.Role.Equals("AGENT"))
            {
                cbAgent.SelectedItem = SharedPrefs.globalUser.Name;
                cbAgent.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigateTo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbAgent.SelectedItem = 0;
            dateDebut.Value = DateTime.Now;
            dateFin.Value = DateTime.Now;
            tbNbrJours.Text = "";
            tbNumTel.Text = "";
            tbAdresse.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Conge conge = new Conge();
            try
            {
                conge.User = users[cbAgent.SelectedIndex];
                
                conge.Nbr_Jours = Convert.ToInt32(tbNbrJours.Text);
                conge.Date_Debut = dateDebut.Value.ToShortDateString();
                conge.Date_Fin = dateFin.Value.ToShortDateString();
                conge.Adresse = tbAdresse.Text;
                conge.Num_Tel = tbNumTel.Text;
                conge.Date_Demande = DateTime.Now.ToShortDateString();
                conge.Etat = "En Attente";

                if (validateFormData(conge))
                {
                    new CongeController().create(conge);

                    MessageBox.Show("demande congé ajouter");
                    navigateTo();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("svp, choisir un agent ?");
            }
            
        }

        private void navigateTo()
        {
            new GestionConge().Show();
            this.Hide();
        }

        private bool validateFormData(Conge conge)
        {
            return true;
        }

        private void tbNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
