namespace RestoENSA
{
    partial class GestionServeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionServeur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.valider_btn = new MetroFramework.Controls.MetroButton();
            this.login_lbl = new MetroFramework.Controls.MetroLabel();
            this.nom_lbl = new MetroFramework.Controls.MetroLabel();
            this.nom_txt = new MetroFramework.Controls.MetroTextBox();
            this.mdp_lbl = new MetroFramework.Controls.MetroLabel();
            this.mdp_txt = new MetroFramework.Controls.MetroTextBox();
            this.confirmer_mdp_lbl = new MetroFramework.Controls.MetroLabel();
            this.confirmer_mdb_txt = new MetroFramework.Controls.MetroTextBox();
            this.vider_btn = new MetroFramework.Controls.MetroButton();
            this.retour_btn = new System.Windows.Forms.Button();
            this.Modif_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.id_txt = new MetroFramework.Controls.MetroTextBox();
            this.login_txt = new MetroFramework.Controls.MetroTextBox();
            this.serveur_grid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.serveur_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // valider_btn
            // 
            this.valider_btn.Location = new System.Drawing.Point(106, 369);
            this.valider_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(119, 35);
            this.valider_btn.TabIndex = 11;
            this.valider_btn.Text = "Ajouter";
            this.valider_btn.UseSelectable = true;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(52, 210);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(43, 20);
            this.login_lbl.TabIndex = 10;
            this.login_lbl.Text = "Login";
            // 
            // nom_lbl
            // 
            this.nom_lbl.AutoSize = true;
            this.nom_lbl.Location = new System.Drawing.Point(52, 164);
            this.nom_lbl.Name = "nom_lbl";
            this.nom_lbl.Size = new System.Drawing.Size(40, 20);
            this.nom_lbl.TabIndex = 9;
            this.nom_lbl.Text = "Nom";
            // 
            // nom_txt
            // 
            // 
            // 
            // 
            this.nom_txt.CustomButton.Image = null;
            this.nom_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.nom_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nom_txt.CustomButton.Name = "";
            this.nom_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_txt.CustomButton.TabIndex = 1;
            this.nom_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_txt.CustomButton.UseSelectable = true;
            this.nom_txt.CustomButton.Visible = false;
            this.nom_txt.Lines = new string[0];
            this.nom_txt.Location = new System.Drawing.Point(286, 164);
            this.nom_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nom_txt.MaxLength = 32767;
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.PasswordChar = '\0';
            this.nom_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_txt.SelectedText = "";
            this.nom_txt.SelectionLength = 0;
            this.nom_txt.SelectionStart = 0;
            this.nom_txt.ShortcutsEnabled = true;
            this.nom_txt.Size = new System.Drawing.Size(233, 23);
            this.nom_txt.TabIndex = 7;
            this.nom_txt.UseSelectable = true;
            this.nom_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdp_lbl
            // 
            this.mdp_lbl.AutoSize = true;
            this.mdp_lbl.Location = new System.Drawing.Point(52, 259);
            this.mdp_lbl.Name = "mdp_lbl";
            this.mdp_lbl.Size = new System.Drawing.Size(92, 20);
            this.mdp_lbl.TabIndex = 13;
            this.mdp_lbl.Text = "Mot de passe";
            // 
            // mdp_txt
            // 
            // 
            // 
            // 
            this.mdp_txt.CustomButton.Image = null;
            this.mdp_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.mdp_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdp_txt.CustomButton.Name = "";
            this.mdp_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp_txt.CustomButton.TabIndex = 1;
            this.mdp_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp_txt.CustomButton.UseSelectable = true;
            this.mdp_txt.CustomButton.Visible = false;
            this.mdp_txt.Lines = new string[0];
            this.mdp_txt.Location = new System.Drawing.Point(286, 256);
            this.mdp_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdp_txt.MaxLength = 32767;
            this.mdp_txt.Name = "mdp_txt";
            this.mdp_txt.PasswordChar = '●';
            this.mdp_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp_txt.SelectedText = "";
            this.mdp_txt.SelectionLength = 0;
            this.mdp_txt.SelectionStart = 0;
            this.mdp_txt.ShortcutsEnabled = true;
            this.mdp_txt.Size = new System.Drawing.Size(233, 23);
            this.mdp_txt.TabIndex = 12;
            this.mdp_txt.UseSelectable = true;
            this.mdp_txt.UseSystemPasswordChar = true;
            this.mdp_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmer_mdp_lbl
            // 
            this.confirmer_mdp_lbl.AutoSize = true;
            this.confirmer_mdp_lbl.Location = new System.Drawing.Point(52, 310);
            this.confirmer_mdp_lbl.Name = "confirmer_mdp_lbl";
            this.confirmer_mdp_lbl.Size = new System.Drawing.Size(173, 20);
            this.confirmer_mdp_lbl.TabIndex = 15;
            this.confirmer_mdp_lbl.Text = "Confirmer le mot de passe";
            // 
            // confirmer_mdb_txt
            // 
            // 
            // 
            // 
            this.confirmer_mdb_txt.CustomButton.Image = null;
            this.confirmer_mdb_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.confirmer_mdb_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmer_mdb_txt.CustomButton.Name = "";
            this.confirmer_mdb_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmer_mdb_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmer_mdb_txt.CustomButton.TabIndex = 1;
            this.confirmer_mdb_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmer_mdb_txt.CustomButton.UseSelectable = true;
            this.confirmer_mdb_txt.CustomButton.Visible = false;
            this.confirmer_mdb_txt.Lines = new string[0];
            this.confirmer_mdb_txt.Location = new System.Drawing.Point(286, 307);
            this.confirmer_mdb_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmer_mdb_txt.MaxLength = 32767;
            this.confirmer_mdb_txt.Name = "confirmer_mdb_txt";
            this.confirmer_mdb_txt.PasswordChar = '●';
            this.confirmer_mdb_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmer_mdb_txt.SelectedText = "";
            this.confirmer_mdb_txt.SelectionLength = 0;
            this.confirmer_mdb_txt.SelectionStart = 0;
            this.confirmer_mdb_txt.ShortcutsEnabled = true;
            this.confirmer_mdb_txt.Size = new System.Drawing.Size(233, 23);
            this.confirmer_mdb_txt.TabIndex = 14;
            this.confirmer_mdb_txt.UseSelectable = true;
            this.confirmer_mdb_txt.UseSystemPasswordChar = true;
            this.confirmer_mdb_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmer_mdb_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vider_btn
            // 
            this.vider_btn.Location = new System.Drawing.Point(203, 410);
            this.vider_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(171, 34);
            this.vider_btn.TabIndex = 16;
            this.vider_btn.Text = "Vider les champs";
            this.vider_btn.UseSelectable = true;
            this.vider_btn.Click += new System.EventHandler(this.vider_btn_Click);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(35, 75);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 17;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // Modif_btn
            // 
            this.Modif_btn.Location = new System.Drawing.Point(232, 369);
            this.Modif_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Modif_btn.Name = "Modif_btn";
            this.Modif_btn.Size = new System.Drawing.Size(116, 35);
            this.Modif_btn.TabIndex = 19;
            this.Modif_btn.Text = "Modifier";
            this.Modif_btn.UseSelectable = true;
            this.Modif_btn.Click += new System.EventHandler(this.Modif_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.Location = new System.Drawing.Point(356, 369);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(123, 35);
            this.supprimer_btn.TabIndex = 20;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // id_txt
            // 
            // 
            // 
            // 
            this.id_txt.CustomButton.Image = null;
            this.id_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.id_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_txt.CustomButton.Name = "";
            this.id_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_txt.CustomButton.TabIndex = 1;
            this.id_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_txt.CustomButton.UseSelectable = true;
            this.id_txt.CustomButton.Visible = false;
            this.id_txt.Lines = new string[0];
            this.id_txt.Location = new System.Drawing.Point(286, 116);
            this.id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_txt.MaxLength = 32767;
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '\0';
            this.id_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_txt.SelectedText = "";
            this.id_txt.SelectionLength = 0;
            this.id_txt.SelectionStart = 0;
            this.id_txt.ShortcutsEnabled = true;
            this.id_txt.Size = new System.Drawing.Size(233, 23);
            this.id_txt.TabIndex = 22;
            this.id_txt.UseSelectable = true;
            this.id_txt.Visible = false;
            this.id_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_txt
            // 
            // 
            // 
            // 
            this.login_txt.CustomButton.Image = null;
            this.login_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.login_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_txt.CustomButton.Name = "";
            this.login_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_txt.CustomButton.TabIndex = 1;
            this.login_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_txt.CustomButton.UseSelectable = true;
            this.login_txt.CustomButton.Visible = false;
            this.login_txt.Lines = new string[0];
            this.login_txt.Location = new System.Drawing.Point(286, 210);
            this.login_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_txt.MaxLength = 32767;
            this.login_txt.Name = "login_txt";
            this.login_txt.PasswordChar = '\0';
            this.login_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_txt.SelectedText = "";
            this.login_txt.SelectionLength = 0;
            this.login_txt.SelectionStart = 0;
            this.login_txt.ShortcutsEnabled = true;
            this.login_txt.Size = new System.Drawing.Size(233, 23);
            this.login_txt.TabIndex = 23;
            this.login_txt.UseSelectable = true;
            this.login_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serveur_grid
            // 
            this.serveur_grid.AllowUserToResizeRows = false;
            this.serveur_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serveur_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serveur_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serveur_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.serveur_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serveur_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serveur_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serveur_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.serveur_grid.EnableHeadersVisualStyles = false;
            this.serveur_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serveur_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serveur_grid.Location = new System.Drawing.Point(550, 75);
            this.serveur_grid.Name = "serveur_grid";
            this.serveur_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serveur_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.serveur_grid.RowHeadersWidth = 51;
            this.serveur_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serveur_grid.RowTemplate.Height = 24;
            this.serveur_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serveur_grid.Size = new System.Drawing.Size(574, 369);
            this.serveur_grid.TabIndex = 24;
            this.serveur_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serveur_grid_CellClick);
            // 
            // GestionServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 478);
            this.Controls.Add(this.serveur_grid);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.Modif_btn);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.vider_btn);
            this.Controls.Add(this.confirmer_mdp_lbl);
            this.Controls.Add(this.confirmer_mdb_txt);
            this.Controls.Add(this.mdp_lbl);
            this.Controls.Add(this.mdp_txt);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.nom_lbl);
            this.Controls.Add(this.nom_txt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionServeur";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Gestion des serveurs";
            this.Load += new System.EventHandler(this.GestionServeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serveur_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton valider_btn;
        private MetroFramework.Controls.MetroLabel login_lbl;
        private MetroFramework.Controls.MetroLabel nom_lbl;
        private MetroFramework.Controls.MetroTextBox nom_txt;
        private MetroFramework.Controls.MetroLabel mdp_lbl;
        private MetroFramework.Controls.MetroTextBox mdp_txt;
        private MetroFramework.Controls.MetroLabel confirmer_mdp_lbl;
        private MetroFramework.Controls.MetroTextBox confirmer_mdb_txt;
        private MetroFramework.Controls.MetroButton vider_btn;
        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroButton Modif_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroTextBox id_txt;
        private MetroFramework.Controls.MetroTextBox login_txt;
        private MetroFramework.Controls.MetroGrid serveur_grid;
    }
}