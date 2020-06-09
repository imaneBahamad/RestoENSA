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
            this.SuspendLayout();
            // 
            // gestion_serveurs_btn
            // 
            this.gestion_serveurs_btn.Location = new System.Drawing.Point(42, 95);
            this.gestion_serveurs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_serveurs_btn.Name = "gestion_serveurs_btn";
            this.gestion_serveurs_btn.Size = new System.Drawing.Size(126, 46);
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
            this.logout_btn.Location = new System.Drawing.Point(790, 31);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(45, 46);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // bienvenue_lbl
            // 
            this.bienvenue_lbl.Location = new System.Drawing.Point(244, 31);
            this.bienvenue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bienvenue_lbl.Name = "bienvenue_lbl";
            this.bienvenue_lbl.Size = new System.Drawing.Size(331, 29);
            this.bienvenue_lbl.TabIndex = 2;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(532, 95);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(107, 46);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Gestion Des tables";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.gestion_table_click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(368, 95);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(107, 46);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Gestion Des Categories";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.gestion_categorie_click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(214, 95);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(107, 46);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Gestion Des Plats";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.gestion_plat_click);
            // 
            // ModeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 489);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.bienvenue_lbl);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.gestion_serveurs_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModeAdmin";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
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
    }
}