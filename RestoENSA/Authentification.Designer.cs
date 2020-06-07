namespace RestoENSA
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.qui_combo = new MetroFramework.Controls.MetroComboBox();
            this.qui_lbl = new MetroFramework.Controls.MetroLabel();
            this.utilisateur_txt = new MetroFramework.Controls.MetroTextBox();
            this.mdp_txt = new MetroFramework.Controls.MetroTextBox();
            this.utilisateur_lbl = new MetroFramework.Controls.MetroLabel();
            this.mdp_lbl = new MetroFramework.Controls.MetroLabel();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // qui_combo
            // 
            this.qui_combo.FormattingEnabled = true;
            this.qui_combo.ItemHeight = 24;
            this.qui_combo.Items.AddRange(new object[] {
            "Admin",
            "Serveur"});
            this.qui_combo.Location = new System.Drawing.Point(336, 137);
            this.qui_combo.Name = "qui_combo";
            this.qui_combo.Size = new System.Drawing.Size(250, 30);
            this.qui_combo.TabIndex = 0;
            this.qui_combo.UseSelectable = true;
            // 
            // qui_lbl
            // 
            this.qui_lbl.AutoSize = true;
            this.qui_lbl.Location = new System.Drawing.Point(206, 147);
            this.qui_lbl.Name = "qui_lbl";
            this.qui_lbl.Size = new System.Drawing.Size(81, 20);
            this.qui_lbl.TabIndex = 1;
            this.qui_lbl.Text = "Vous-etes ?";
            // 
            // utilisateur_txt
            // 
            // 
            // 
            // 
            this.utilisateur_txt.CustomButton.Image = null;
            this.utilisateur_txt.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.utilisateur_txt.CustomButton.Name = "";
            this.utilisateur_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.utilisateur_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.utilisateur_txt.CustomButton.TabIndex = 1;
            this.utilisateur_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utilisateur_txt.CustomButton.UseSelectable = true;
            this.utilisateur_txt.CustomButton.Visible = false;
            this.utilisateur_txt.Lines = new string[0];
            this.utilisateur_txt.Location = new System.Drawing.Point(336, 234);
            this.utilisateur_txt.MaxLength = 32767;
            this.utilisateur_txt.Name = "utilisateur_txt";
            this.utilisateur_txt.PasswordChar = '\0';
            this.utilisateur_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.utilisateur_txt.SelectedText = "";
            this.utilisateur_txt.SelectionLength = 0;
            this.utilisateur_txt.SelectionStart = 0;
            this.utilisateur_txt.ShortcutsEnabled = true;
            this.utilisateur_txt.Size = new System.Drawing.Size(250, 23);
            this.utilisateur_txt.TabIndex = 2;
            this.utilisateur_txt.UseSelectable = true;
            this.utilisateur_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.utilisateur_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdp_txt
            // 
            // 
            // 
            // 
            this.mdp_txt.CustomButton.Image = null;
            this.mdp_txt.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.mdp_txt.CustomButton.Name = "";
            this.mdp_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp_txt.CustomButton.TabIndex = 1;
            this.mdp_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp_txt.CustomButton.UseSelectable = true;
            this.mdp_txt.CustomButton.Visible = false;
            this.mdp_txt.Lines = new string[0];
            this.mdp_txt.Location = new System.Drawing.Point(336, 296);
            this.mdp_txt.MaxLength = 32767;
            this.mdp_txt.Name = "mdp_txt";
            this.mdp_txt.PasswordChar = '●';
            this.mdp_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp_txt.SelectedText = "";
            this.mdp_txt.SelectionLength = 0;
            this.mdp_txt.SelectionStart = 0;
            this.mdp_txt.ShortcutsEnabled = true;
            this.mdp_txt.Size = new System.Drawing.Size(250, 23);
            this.mdp_txt.TabIndex = 3;
            this.mdp_txt.UseSelectable = true;
            this.mdp_txt.UseSystemPasswordChar = true;
            this.mdp_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // utilisateur_lbl
            // 
            this.utilisateur_lbl.AutoSize = true;
            this.utilisateur_lbl.Location = new System.Drawing.Point(206, 234);
            this.utilisateur_lbl.Name = "utilisateur_lbl";
            this.utilisateur_lbl.Size = new System.Drawing.Size(70, 20);
            this.utilisateur_lbl.TabIndex = 4;
            this.utilisateur_lbl.Text = "Utilisateur";
            // 
            // mdp_lbl
            // 
            this.mdp_lbl.AutoSize = true;
            this.mdp_lbl.Location = new System.Drawing.Point(206, 299);
            this.mdp_lbl.Name = "mdp_lbl";
            this.mdp_lbl.Size = new System.Drawing.Size(92, 20);
            this.mdp_lbl.TabIndex = 5;
            this.mdp_lbl.Text = "Mot de passe";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(336, 403);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(139, 54);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Se connecter";
            this.login_btn.UseSelectable = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 543);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.mdp_lbl);
            this.Controls.Add(this.utilisateur_lbl);
            this.Controls.Add(this.mdp_txt);
            this.Controls.Add(this.utilisateur_txt);
            this.Controls.Add(this.qui_lbl);
            this.Controls.Add(this.qui_combo);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox qui_combo;
        private MetroFramework.Controls.MetroLabel qui_lbl;
        private MetroFramework.Controls.MetroTextBox utilisateur_txt;
        private MetroFramework.Controls.MetroTextBox mdp_txt;
        private MetroFramework.Controls.MetroLabel utilisateur_lbl;
        private MetroFramework.Controls.MetroLabel mdp_lbl;
        private MetroFramework.Controls.MetroButton login_btn;
    }
}

