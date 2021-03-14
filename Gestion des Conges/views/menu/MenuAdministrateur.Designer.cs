
namespace Gestion_des_Conges.views
{
    partial class MenuAdministrateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnSoldeAgents = new System.Windows.Forms.Button();
            this.btnGestionDesAgents = new System.Windows.Forms.Button();
            this.btnGestionDesDemandes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(383, 223);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(199, 103);
            this.btnDeconnexion.TabIndex = 7;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnSoldeAgents
            // 
            this.btnSoldeAgents.Location = new System.Drawing.Point(63, 223);
            this.btnSoldeAgents.Name = "btnSoldeAgents";
            this.btnSoldeAgents.Size = new System.Drawing.Size(199, 103);
            this.btnSoldeAgents.TabIndex = 6;
            this.btnSoldeAgents.Text = "Solde Agents";
            this.btnSoldeAgents.UseVisualStyleBackColor = true;
            this.btnSoldeAgents.Click += new System.EventHandler(this.btnSoldeAgents_Click);
            // 
            // btnGestionDesAgents
            // 
            this.btnGestionDesAgents.Location = new System.Drawing.Point(383, 64);
            this.btnGestionDesAgents.Name = "btnGestionDesAgents";
            this.btnGestionDesAgents.Size = new System.Drawing.Size(199, 103);
            this.btnGestionDesAgents.TabIndex = 5;
            this.btnGestionDesAgents.Text = "Gestion des Agents";
            this.btnGestionDesAgents.UseVisualStyleBackColor = true;
            this.btnGestionDesAgents.Click += new System.EventHandler(this.btnGestionDesAgents_Click);
            // 
            // btnGestionDesDemandes
            // 
            this.btnGestionDesDemandes.Location = new System.Drawing.Point(63, 64);
            this.btnGestionDesDemandes.Name = "btnGestionDesDemandes";
            this.btnGestionDesDemandes.Size = new System.Drawing.Size(199, 103);
            this.btnGestionDesDemandes.TabIndex = 4;
            this.btnGestionDesDemandes.Text = "Gestion des Demandes";
            this.btnGestionDesDemandes.UseVisualStyleBackColor = true;
            this.btnGestionDesDemandes.Click += new System.EventHandler(this.btnGestionDesDemandes_Click);
            // 
            // MenuAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnSoldeAgents);
            this.Controls.Add(this.btnGestionDesAgents);
            this.Controls.Add(this.btnGestionDesDemandes);
            this.Name = "MenuAdministrateur";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnSoldeAgents;
        private System.Windows.Forms.Button btnGestionDesAgents;
        private System.Windows.Forms.Button btnGestionDesDemandes;
    }
}