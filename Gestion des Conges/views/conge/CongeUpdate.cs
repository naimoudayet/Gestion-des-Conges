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
    public partial class CongeUpdate : Form
    {
        UserController userController;
        CongeController congeController;

        List<User> users;
        Conge conge;

        public CongeUpdate()
        {
            congeController = new CongeController();
            userController = new UserController();

            InitializeComponent();

            tbNbrJours.MaxLength = 3;
            tbNumTel.MaxLength = 8;

            users = userController.readAll();
            initComboBoxAgent(users);
             
            conge = congeController.readOne(GestionConge.selectedItemId);
            if (conge != null)
            {
                cbAgent.SelectedItem = conge.User.Name;
                dateDebut.Value = Convert.ToDateTime(conge.Date_Debut);
                dateFin.Value = Convert.ToDateTime(conge.Date_Fin);

                tbNbrJours.Text = Convert.ToString(conge.Nbr_Jours);
                tbAdresse.Text = conge.Adresse;
                tbNumTel.Text = conge.Num_Tel;

                tbDateDemande.Text = conge.Date_Demande.Substring(0, 10);
                tbDateDemande.Enabled = false;

                tbEtat.Text = conge.Etat;
                tbEtat.Enabled = false;

                if(conge.Etat == "En Attente")
                {
                    btnAccept.Enabled = true;
                    btnRefuse.Enabled = true;
                }
                else if (conge.Etat == "Accepter" || conge.Etat == "Refuser")
                {
                    btnAccept.Enabled = false;
                    btnRefuse.Enabled = false;
                    btnUpdate.Enabled = false;

                    cbAgent.Enabled = false;

                    tbNbrJours.Enabled = false;
                    dateDebut.Enabled = false;
                    dateFin.Enabled = false;
                    tbAdresse.Enabled = false;
                    tbNumTel.Enabled = false;
                }
            }
        }

        private void initComboBoxAgent(List<User> users)
        {
            foreach (User u in users)
            {
                cbAgent.Items.Add(u.Name);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigateTo();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conge.User = users[cbAgent.SelectedIndex];

                conge.Nbr_Jours = Convert.ToInt32(tbNbrJours.Text);
                conge.Date_Debut = dateDebut.Value.ToShortDateString();
                conge.Date_Fin = dateFin.Value.ToShortDateString();
                conge.Adresse = tbAdresse.Text;
                conge.Num_Tel = tbNumTel.Text;

                if (validateFormData(conge))
                {
                    new CongeController().update(conge);

                    MessageBox.Show("demande congé modifier");
                    navigateTo();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("svp, choisir un agent ?");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Supprimer Demande Congé ?",
                "Confirmation",
                MessageBoxButtons.YesNo
                );

            if(result == DialogResult.Yes)
            {
                new CongeController().delete(conge.ID);

                MessageBox.Show("demande congé supprimer");
                navigateTo();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Accepter Demande Congé ?",
               "Confirmation",
               MessageBoxButtons.YesNo
               );
            conge.Etat = "Accepter";

            if (result == DialogResult.Yes)
            {
                new CongeController().update(conge);

                MessageBox.Show("demande congé accepter");
                navigateTo();
            }
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Refuser Demande Congé ?",
               "Confirmation",
               MessageBoxButtons.YesNo
               );
            conge.Etat = "Refuser";

            if (result == DialogResult.Yes)
            {
                new CongeController().update(conge);

                MessageBox.Show("demande congé refuser");
                navigateTo();
            }
        }
    }
}
