
namespace Gestion_des_Conges.views.conge
{
    partial class GestionConge
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvDemande = new System.Windows.Forms.DataGridView();
            this.btnAddDemande = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestion des Congés";
            // 
            // gvDemande
            // 
            this.gvDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDemande.Location = new System.Drawing.Point(13, 112);
            this.gvDemande.Name = "gvDemande";
            this.gvDemande.Size = new System.Drawing.Size(743, 262);
            this.gvDemande.TabIndex = 9;
            this.gvDemande.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDemande_CellMouseClick);
            // 
            // btnAddDemande
            // 
            this.btnAddDemande.Location = new System.Drawing.Point(582, 67);
            this.btnAddDemande.Name = "btnAddDemande";
            this.btnAddDemande.Size = new System.Drawing.Size(157, 23);
            this.btnAddDemande.TabIndex = 8;
            this.btnAddDemande.Text = "Add Demande";
            this.btnAddDemande.UseVisualStyleBackColor = true;
            this.btnAddDemande.Click += new System.EventHandler(this.btnAddDemande_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(17, 67);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(157, 23);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Back";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // GestionConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDemande);
            this.Controls.Add(this.btnAddDemande);
            this.Name = "GestionConge";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Congés";
            ((System.ComponentModel.ISupportInitialize)(this.gvDemande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvDemande;
        private System.Windows.Forms.Button btnAddDemande;
        private System.Windows.Forms.Button btnRetour;
    }
}