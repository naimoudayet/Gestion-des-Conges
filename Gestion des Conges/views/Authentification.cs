using Gestion_des_Conges.config;
using Gestion_des_Conges.controller;
using Gestion_des_Conges.model;
using Gestion_des_Conges.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_Conges
{
    public partial class Authentification : Form
    {
        UserController userController;

        public Authentification()
        {

            userController = new UserController();

            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Email= tbLogin.Text;
            user.Password = tbPassword.Text;

             if(validateFormData(user))
            {
                User result = userController.login(user);
                 
                if (result.ID == 0)
                {
                    MessageBox.Show("Email ou mot de passe érronée!", "Error");
                }
                else
                {
                    SharedPrefs.globalUser = result;

                    if (result.Role == "ADMIN")
                    {

                        MenuAdministrateur menu = new MenuAdministrateur();
                        menu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MenuAgent menu = new MenuAgent();
                        menu.Show();
                        this.Hide();

                    }
                }
            }
              
        }

        private bool validateFormData(User user)
        { 
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
