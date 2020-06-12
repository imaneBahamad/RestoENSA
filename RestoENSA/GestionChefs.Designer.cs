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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nom_label = new MetroFramework.Controls.MetroLabel();
            this.Ajouter_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.nom_txt = new MetroFramework.Controls.MetroTextBox();
            this.retour_btn = new System.Windows.Forms.Button();
            this.id_txt = new MetroFramework.Controls.MetroTextBox();
            this.chef_grid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.chef_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Location = new System.Drawing.Point(98, 194);
            this.nom_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(40, 20);
            this.nom_label.TabIndex = 0;
            this.nom_label.Text = "Nom";
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.Location = new System.Drawing.Point(103, 293);
            this.Ajouter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(100, 30);
            this.Ajouter_btn.TabIndex = 1;
            this.Ajouter_btn.Text = "Ajouter";
            this.Ajouter_btn.UseSelectable = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // modif_btn
            // 
            this.modif_btn.Location = new System.Drawing.Point(211, 293);
            this.modif_btn.Margin = new System.Windows.Forms.Padding(4);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(100, 30);
            this.modif_btn.TabIndex = 2;
            this.modif_btn.Text = "Modifier";
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.modif_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.Location = new System.Drawing.Point(319, 294);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(100, 29);
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
            this.nom_txt.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.nom_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.nom_txt.CustomButton.Name = "";
            this.nom_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nom_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_txt.CustomButton.TabIndex = 1;
            this.nom_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_txt.CustomButton.UseSelectable = true;
            this.nom_txt.CustomButton.Visible = false;
            this.nom_txt.Lines = new string[0];
            this.nom_txt.Location = new System.Drawing.Point(191, 186);
            this.nom_txt.Margin = new System.Windows.Forms.Padding(4);
            this.nom_txt.MaxLength = 32767;
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.PasswordChar = '\0';
            this.nom_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_txt.SelectedText = "";
            this.nom_txt.SelectionLength = 0;
            this.nom_txt.SelectionStart = 0;
            this.nom_txt.ShortcutsEnabled = true;
            this.nom_txt.Size = new System.Drawing.Size(244, 28);
            this.nom_txt.TabIndex = 4;
            this.nom_txt.UseSelectable = true;
            this.nom_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(29, 87);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 18;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // id_txt
            // 
            // 
            // 
            // 
            this.id_txt.CustomButton.Image = null;
            this.id_txt.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.id_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt.CustomButton.Name = "";
            this.id_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.id_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_txt.CustomButton.TabIndex = 1;
            this.id_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_txt.CustomButton.UseSelectable = true;
            this.id_txt.CustomButton.Visible = false;
            this.id_txt.Lines = new string[0];
            this.id_txt.Location = new System.Drawing.Point(191, 101);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt.MaxLength = 32767;
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '\0';
            this.id_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_txt.SelectedText = "";
            this.id_txt.SelectionLength = 0;
            this.id_txt.SelectionStart = 0;
            this.id_txt.ShortcutsEnabled = true;
            this.id_txt.Size = new System.Drawing.Size(244, 28);
            this.id_txt.TabIndex = 19;
            this.id_txt.UseSelectable = true;
            this.id_txt.Visible = false;
            this.id_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chef_grid
            // 
            this.chef_grid.AllowUserToResizeRows = false;
            this.chef_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chef_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chef_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chef_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.chef_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chef_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.chef_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chef_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.chef_grid.EnableHeadersVisualStyles = false;
            this.chef_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chef_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chef_grid.Location = new System.Drawing.Point(494, 39);
            this.chef_grid.Name = "chef_grid";
            this.chef_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chef_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.chef_grid.RowHeadersWidth = 51;
            this.chef_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.chef_grid.RowTemplate.Height = 24;
            this.chef_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chef_grid.Size = new System.Drawing.Size(528, 296);
            this.chef_grid.TabIndex = 25;
            this.chef_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chef_grid_CellClick);
            // 
            // GestionChefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 363);
            this.Controls.Add(this.chef_grid);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.nom_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionChefs";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Gestion des Chefs";
            this.Load += new System.EventHandler(this.GestionChefs_Load);
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
        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroTextBox id_txt;
        private MetroFramework.Controls.MetroGrid chef_grid;
    }
}