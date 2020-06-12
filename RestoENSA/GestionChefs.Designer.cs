namespace RestoENSA
{
    partial class GestionChefs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionChefs));
            this.nom_label = new MetroFramework.Controls.MetroLabel();
            this.Ajouter_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.nom_txt = new MetroFramework.Controls.MetroTextBox();
            this.chef_grid = new System.Windows.Forms.DataGridView();
            this.retour_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chef_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Location = new System.Drawing.Point(49, 154);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(46, 19);
            this.nom_label.TabIndex = 0;
            this.nom_label.Text = "Nom :";
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.Location = new System.Drawing.Point(49, 238);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(75, 41);
            this.Ajouter_btn.TabIndex = 1;
            this.Ajouter_btn.Text = "Ajouter";
            this.Ajouter_btn.UseSelectable = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // modif_btn
            // 
            this.modif_btn.Location = new System.Drawing.Point(165, 238);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(75, 41);
            this.modif_btn.TabIndex = 2;
            this.modif_btn.Text = "Modifier";
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.modif_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.Location = new System.Drawing.Point(302, 238);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(75, 41);
            this.supprimer_btn.TabIndex = 3;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // nom_txt
            // 
            // 
            // 
            // 
            this.nom_txt.CustomButton.Image = null;
            this.nom_txt.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.nom_txt.CustomButton.Name = "";
            this.nom_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_txt.CustomButton.TabIndex = 1;
            this.nom_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_txt.CustomButton.UseSelectable = true;
            this.nom_txt.CustomButton.Visible = false;
            this.nom_txt.Lines = new string[0];
            this.nom_txt.Location = new System.Drawing.Point(165, 150);
            this.nom_txt.MaxLength = 32767;
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.PasswordChar = '\0';
            this.nom_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_txt.SelectedText = "";
            this.nom_txt.SelectionLength = 0;
            this.nom_txt.SelectionStart = 0;
            this.nom_txt.ShortcutsEnabled = true;
            this.nom_txt.Size = new System.Drawing.Size(183, 23);
            this.nom_txt.TabIndex = 4;
            this.nom_txt.UseSelectable = true;
            this.nom_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chef_grid
            // 
            this.chef_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chef_grid.Location = new System.Drawing.Point(427, 129);
            this.chef_grid.Name = "chef_grid";
            this.chef_grid.Size = new System.Drawing.Size(329, 150);
            this.chef_grid.TabIndex = 5;
            this.chef_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chef_grid_CellClick);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(22, 71);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(44, 44);
            this.retour_btn.TabIndex = 18;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // GestionChefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 431);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.chef_grid);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.nom_label);
            this.Name = "GestionChefs";
            this.Text = "Gestion des Chefs";
            ((System.ComponentModel.ISupportInitialize)(this.chef_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nom_label;
        private MetroFramework.Controls.MetroButton Ajouter_btn;
        private MetroFramework.Controls.MetroButton modif_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroTextBox nom_txt;
        private System.Windows.Forms.DataGridView chef_grid;
        private System.Windows.Forms.Button retour_btn;
    }
}