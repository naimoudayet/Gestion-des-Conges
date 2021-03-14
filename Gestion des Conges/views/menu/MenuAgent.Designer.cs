
namespace Gestion_des_Conges.views
{
    partial class MenuAgent
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
            this.btnDemandeConge = new System.Windows.Forms.Button();
            this.btnMesDemandes = new System.Windows.Forms.Button();
            this.btnMonSolde = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemandeConge
            // 
            this.btnDemandeConge.Location = new System.Drawing.Point(55, 56);
            this.btnDemandeConge.Name = "btnDemandeConge";
            this.btnDemandeConge.Size = new System.Drawing.Size(199, 103);
            this.btnDemandeConge.TabIndex = 0;
            this.btnDemandeConge.Text = "Demande de Congé";
            this.btnDemandeConge.UseVisualStyleBackColor = true;
            this.btnDemandeConge.Click += new System.EventHandler(this.btnDemandeConge_Click);
            // 
            // btnMesDemandes
            // 
            this.btnMesDemandes.Location = new System.Drawing.Point(375, 56);
            this.btnMesDemandes.Name = "btnMesDemandes";
            this.btnMesDemandes.Size = new System.Drawing.Size(199, 103);
            this.btnMesDemandes.TabIndex = 1;
            this.btnMesDemandes.Text = "Mes Demandes";
            this.btnMesDemandes.UseVisualStyleBackColor = true;
            this.btnMesDemandes.Click += new System.EventHandler(this.btnMesDemandes_Click);
            // 
            // btnMonSolde
            // 
            this.btnMonSolde.Location = new System.Drawing.Point(55, 215);
            this.btnMonSolde.Name = "btnMonSolde";
            this.btnMonSolde.Size = new System.Drawing.Size(199, 103);
            this.btnMonSolde.TabIndex = 2;
            this.btnMonSolde.Text = "Mon Solde";
            this.btnMonSolde.UseVisualStyleBackColor = true;
            this.btnMonSolde.Click += new System.EventHandler(this.btnMonSolde_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(375, 215);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(199, 103);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // MenuAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnMonSolde);
            this.Controls.Add(this.btnMesDemandes);
            this.Controls.Add(this.btnDemandeConge);
            this.Name = "MenuAgent";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemandeConge;
        private System.Windows.Forms.Button btnMesDemandes;
        private System.Windows.Forms.Button btnMonSolde;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}