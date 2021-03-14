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

namespace Gestion_des_Conges.views.agent
{
    public partial class GestionDesAgents : Form
    {
        public static int selectedItemId = 0;

        UserController userController;
        List<User> userList;

        public GestionDesAgents()
        {
            userController = new UserController();

            InitializeComponent();

            getAllAgent();
        }

        private void getAllAgent()
        {
            userList = userController.readAll();

            int width = 169;

            gvUsers.ColumnCount = 3;

            gvUsers.Columns[0].Name = "ID";
            gvUsers.Columns[0].Width = width;

            gvUsers.Columns[1].Name = "Name";
            gvUsers.Columns[1].Width = width;

            gvUsers.Columns[2].Name = "Email";
            gvUsers.Columns[2].Width = width;

            foreach(User u in userList)
            {
                string[] row = new string[]
                {
                    Convert.ToString(u.ID),
                    u.Name,
                    u.Email
                };

                gvUsers.Rows.Add(row);
            }

        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            new AgentAdd().Show();
            this.Hide();
        }

        private void gvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0 && index <= userList.Count)
            {
                User user = userList[index];
                selectedItemId = user.ID;

                new AgentUpdate().Show();
                this.Hide();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MenuAdministrateur().Show();
            this.Hide();
        }
    }
}
