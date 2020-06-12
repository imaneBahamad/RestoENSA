namespace RestoENSA
{
    partial class ModeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeAdmin));
            this.gestion_serveurs_btn = new MetroFramework.Controls.MetroButton();
            this.logout_btn = new System.Windows.Forms.Button();
            this.bienvenue_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Gestion_chefs_btn = new MetroFramework.Controls.MetroButton();
            this.Gestion_horaire_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // gestion_serveurs_btn
            // 
            this.gestion_serveurs_btn.Location = new System.Drawing.Point(136, 142);
            this.gestion_serveurs_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gestion_serveurs_btn.Name = "gestion_serveurs_btn";
            this.gestion_serveurs_btn.Size = new System.Drawing.Size(178, 57);
            this.gestion_serveurs_btn.TabIndex = 0;
            this.gestion_serveurs_btn.Text = "Gestion des serveurs";
            this.gestion_serveurs_btn.UseSelectable = true;
            this.gestion_serveurs_btn.Click += new System.EventHandler(this.gestion_serveurs_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(1053, 38);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(60, 57);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // bienvenue_lbl
            // 
            this.bienvenue_lbl.Location = new System.Drawing.Point(325, 38);
            this.bienvenue_lbl.Name = "bienvenue_lbl";
            this.bienvenue_lbl.Size = new System.Drawing.Size(441, 36);
            this.bienvenue_lbl.TabIndex = 2;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(366, 244);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(178, 57);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Gestion des tables";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.gestion_table_click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(588, 142);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(178, 57);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Gestion des catégories";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.gestion_categorie_click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(136, 244);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(178, 57);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Gestion des plats";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.gestion_plat_click);
            // 
            // Gestion_chefs_btn
            // 
            this.Gestion_chefs_btn.Location = new System.Drawing.Point(366, 142);
            this.Gestion_chefs_btn.Name = "Gestion_chefs_btn";
            this.Gestion_chefs_btn.Size = new System.Drawing.Size(178, 57);
            this.Gestion_chefs_btn.TabIndex = 7;
            this.Gestion_chefs_btn.Text = "Gestion des chefs";
            this.Gestion_chefs_btn.UseSelectable = true;
            this.Gestion_chefs_btn.Click += new System.EventHandler(this.Gestion_chefs_btn_Click);
            // 
            // Gestion_horaire_btn
            // 
            this.Gestion_horaire_btn.Location = new System.Drawing.Point(136, 347);
            this.Gestion_horaire_btn.Name = "Gestion_horaire_btn";
            this.Gestion_horaire_btn.Size = new System.Drawing.Size(365, 57);
            this.Gestion_horaire_btn.TabIndex = 8;
            this.Gestion_horaire_btn.Text = "Gestion des shifts et Horaires des personnels";
            this.Gestion_horaire_btn.UseSelectable = true;
            this.Gestion_horaire_btn.Click += new System.EventHandler(this.Gestion_horaire_btn_Click);
            // 
            // ModeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 489);
            this.Controls.Add(this.Gestion_horaire_btn);
            this.Controls.Add(this.Gestion_chefs_btn);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.bienvenue_lbl);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.gestion_serveurs_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModeAdmin";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Mode administrateur";
            this.Load += new System.EventHandler(this.ModeAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton gestion_serveurs_btn;
        private System.Windows.Forms.Button logout_btn;
        private MetroFramework.Controls.MetroLabel bienvenue_lbl;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton Gestion_chefs_btn;
        private MetroFramework.Controls.MetroButton Gestion_horaire_btn;
    }
}