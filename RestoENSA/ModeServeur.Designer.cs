﻿namespace RestoENSA
{
    partial class ModeServeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeServeur));
            this.logout_btn = new System.Windows.Forms.Button();
            this.bienvenue_lbl = new MetroFramework.Controls.MetroLabel();
            this.gestion_serveurs_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(802, 28);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(45, 46);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // bienvenue_lbl
            // 
            this.bienvenue_lbl.Location = new System.Drawing.Point(201, 33);
            this.bienvenue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bienvenue_lbl.Name = "bienvenue_lbl";
            this.bienvenue_lbl.Size = new System.Drawing.Size(331, 29);
            this.bienvenue_lbl.TabIndex = 3;
            // 
            // gestion_serveurs_btn
            // 
            this.gestion_serveurs_btn.Location = new System.Drawing.Point(58, 105);
            this.gestion_serveurs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_serveurs_btn.Name = "gestion_serveurs_btn";
            this.gestion_serveurs_btn.Size = new System.Drawing.Size(166, 46);
            this.gestion_serveurs_btn.TabIndex = 4;
            this.gestion_serveurs_btn.Text = "Ajouter une Commande";
            this.gestion_serveurs_btn.UseSelectable = true;
            this.gestion_serveurs_btn.Click += new System.EventHandler(this.Ajouter_Cmd);
            // 
            // ModeServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 491);
            this.Controls.Add(this.gestion_serveurs_btn);
            this.Controls.Add(this.bienvenue_lbl);
            this.Controls.Add(this.logout_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModeServeur";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Mode serveur";
            this.Load += new System.EventHandler(this.ModeServeur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private MetroFramework.Controls.MetroLabel bienvenue_lbl;
        private MetroFramework.Controls.MetroButton gestion_serveurs_btn;
    }
}