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
    public partial class GestionConge : Form
    {
        public static int selectedItemId = 0;

        CongeController congeController;
        List<Conge> congeList;

        public GestionConge()
        {
            congeController = new CongeController();

            InitializeComponent();

            getAllDemande();
        }

        private void getAllDemande()
        {
            if(SharedPrefs.globalUser.Role.Equals("AGENT"))
            {
                congeList = congeController.readAllById(SharedPrefs.globalUser.ID);
            }
            else
            {
                congeList = congeController.readAll();
            }

            gvDemande.ColumnCount = 7;

            gvDemande.Columns[0].Name = "N°"; 
            gvDemande.Columns[1].Name = "Agent";
            gvDemande.Columns[2].Name = "Date Début";
            gvDemande.Columns[3].Name = "Date Fin";
            gvDemande.Columns[4].Name = "N° des Jours";
            gvDemande.Columns[5].Name = "Date Demande";
            gvDemande.Columns[6].Name = "Etat";

            foreach(Conge c in congeList)
            {
                string[] row = new string[]
                {
                    Convert.ToString(c.ID),
                    c.User.Name,
                    c.Date_Debut.Substring(0, 10),
                    c.Date_Fin.Substring(0, 10),
                    Convert.ToString(c.Nbr_Jours),
                    c.Date_Demande.Substring(0, 10),
                    c.Etat
                };

                gvDemande.Rows.Add(row);
            }
        }

        private void btnAddDemande_Click(object sender, EventArgs e)
        {
            new CongeAdd().Show();
            this.Hide();
        }

        private void gvDemande_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0 && index <= congeList.Count)
            {
                Conge conge= congeList[index];
                selectedItemId = conge.ID;

                new CongeUpdate().Show();
                this.Hide();

            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
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
    }
}
