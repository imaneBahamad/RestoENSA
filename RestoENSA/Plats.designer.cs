﻿namespace RestoENSA
{
    partial class Plats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plats));
            this.crud_plat_panel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.categorie_box = new MetroFramework.Controls.MetroComboBox();
            this.code_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.filtre_combobox = new MetroFramework.Controls.MetroComboBox();
            this.plat_grid = new MetroFramework.Controls.MetroGrid();
            this.prix_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.nom_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crud_plat_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crud_plat_panel
            // 
            this.crud_plat_panel.Controls.Add(this.metroLabel1);
            this.crud_plat_panel.Controls.Add(this.categorie_box);
            this.crud_plat_panel.Controls.Add(this.code_plat_box);
            this.crud_plat_panel.Controls.Add(this.button3);
            this.crud_plat_panel.Controls.Add(this.button2);
            this.crud_plat_panel.Controls.Add(this.button1);
            this.crud_plat_panel.Controls.Add(this.metroLabel5);
            this.crud_plat_panel.Controls.Add(this.metroLabel22);
            this.crud_plat_panel.Controls.Add(this.filtre_combobox);
            this.crud_plat_panel.Controls.Add(this.plat_grid);
            this.crud_plat_panel.Controls.Add(this.prix_plat_box);
            this.crud_plat_panel.Controls.Add(this.metroLabel15);
            this.crud_plat_panel.Controls.Add(this.metroLabel8);
            this.crud_plat_panel.Controls.Add(this.metroLabel20);
            this.crud_plat_panel.Controls.Add(this.nom_plat_box);
            this.crud_plat_panel.Location = new System.Drawing.Point(4, 54);
            this.crud_plat_panel.Name = "crud_plat_panel";
            this.crud_plat_panel.Size = new System.Drawing.Size(792, 353);
            this.crud_plat_panel.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(3, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Categorie :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 23;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(128, 121);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(154, 29);
            this.categorie_box.TabIndex = 61;
            this.categorie_box.UseSelectable = true;
            // 
            // code_plat_box
            // 
            // 
            // 
            // 
            this.code_plat_box.CustomButton.Image = null;
            this.code_plat_box.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.code_plat_box.CustomButton.Name = "";
            this.code_plat_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.code_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_plat_box.CustomButton.TabIndex = 1;
            this.code_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_plat_box.CustomButton.UseSelectable = true;
            this.code_plat_box.CustomButton.Visible = false;
            this.code_plat_box.Lines = new string[0];
            this.code_plat_box.Location = new System.Drawing.Point(128, 15);
            this.code_plat_box.MaxLength = 32767;
            this.code_plat_box.Name = "code_plat_box";
            this.code_plat_box.PasswordChar = '\0';
            this.code_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_plat_box.SelectedText = "";
            this.code_plat_box.SelectionLength = 0;
            this.code_plat_box.SelectionStart = 0;
            this.code_plat_box.ShortcutsEnabled = true;
            this.code_plat_box.Size = new System.Drawing.Size(154, 23);
            this.code_plat_box.TabIndex = 48;
            this.code_plat_box.UseSelectable = true;
            this.code_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.supprimer_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 59;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.modifier_plat_button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ajouter_plat_button);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(296, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 57;
            this.metroLabel5.Text = "Liste des Plats :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel22.Location = new System.Drawing.Point(566, 19);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(83, 19);
            this.metroLabel22.TabIndex = 56;
            this.metroLabel22.Text = "Categorie :";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 23;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(683, 9);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(80, 29);
            this.filtre_combobox.TabIndex = 54;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_combobox_SelectedIndexChanged);
            // 
            // plat_grid
            // 
            this.plat_grid.AllowUserToOrderColumns = true;
            this.plat_grid.AllowUserToResizeRows = false;
            this.plat_grid.BackgroundColor = System.Drawing.Color.Silver;
            this.plat_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plat_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.plat_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.plat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plat_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.plat_grid.EnableHeadersVisualStyles = false;
            this.plat_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plat_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plat_grid.Location = new System.Drawing.Point(296, 52);
            this.plat_grid.Name = "plat_grid";
            this.plat_grid.ReadOnly = true;
            this.plat_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.plat_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.plat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plat_grid.Size = new System.Drawing.Size(467, 274);
            this.plat_grid.TabIndex = 55;
            this.plat_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plat_grid_CellContentClick);
            // 
            // prix_plat_box
            // 
            // 
            // 
            // 
            this.prix_plat_box.CustomButton.Image = null;
            this.prix_plat_box.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.prix_plat_box.CustomButton.Name = "";
            this.prix_plat_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prix_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix_plat_box.CustomButton.TabIndex = 1;
            this.prix_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix_plat_box.CustomButton.UseSelectable = true;
            this.prix_plat_box.CustomButton.Visible = false;
            this.prix_plat_box.Lines = new string[0];
            this.prix_plat_box.Location = new System.Drawing.Point(128, 81);
            this.prix_plat_box.MaxLength = 32767;
            this.prix_plat_box.Name = "prix_plat_box";
            this.prix_plat_box.PasswordChar = '\0';
            this.prix_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix_plat_box.SelectedText = "";
            this.prix_plat_box.SelectionLength = 0;
            this.prix_plat_box.SelectionStart = 0;
            this.prix_plat_box.ShortcutsEnabled = true;
            this.prix_plat_box.Size = new System.Drawing.Size(154, 23);
            this.prix_plat_box.TabIndex = 53;
            this.prix_plat_box.UseSelectable = true;
            this.prix_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prix_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel15.Location = new System.Drawing.Point(3, 52);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(50, 19);
            this.metroLabel15.TabIndex = 52;
            this.metroLabel15.Text = "Nom :";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(3, 85);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 51;
            this.metroLabel8.Text = "Prix (dhs) :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel20.Location = new System.Drawing.Point(3, 19);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(82, 19);
            this.metroLabel20.TabIndex = 50;
            this.metroLabel20.Text = "Code Plat :";
            this.metroLabel20.UseCustomBackColor = true;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // nom_plat_box
            // 
            // 
            // 
            // 
            this.nom_plat_box.CustomButton.Image = null;
            this.nom_plat_box.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.nom_plat_box.CustomButton.Name = "";
            this.nom_plat_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_plat_box.CustomButton.TabIndex = 1;
            this.nom_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_plat_box.CustomButton.UseSelectable = true;
            this.nom_plat_box.CustomButton.Visible = false;
            this.nom_plat_box.Lines = new string[0];
            this.nom_plat_box.Location = new System.Drawing.Point(128, 48);
            this.nom_plat_box.MaxLength = 32767;
            this.nom_plat_box.Name = "nom_plat_box";
            this.nom_plat_box.PasswordChar = '\0';
            this.nom_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_plat_box.SelectedText = "";
            this.nom_plat_box.SelectionLength = 0;
            this.nom_plat_box.SelectionStart = 0;
            this.nom_plat_box.ShortcutsEnabled = true;
            this.nom_plat_box.Size = new System.Drawing.Size(154, 23);
            this.nom_plat_box.TabIndex = 49;
            this.nom_plat_box.UseSelectable = true;
            this.nom_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Quitter_button);
            // 
            // Plats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crud_plat_panel);
            this.Name = "Plats";
            this.Text = "Plats";
            this.crud_plat_panel.ResumeLayout(false);
            this.crud_plat_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel crud_plat_panel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox filtre_combobox;
        private MetroFramework.Controls.MetroGrid plat_grid;
        private MetroFramework.Controls.MetroTextBox prix_plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox nom_plat_box;
        private MetroFramework.Controls.MetroTextBox code_plat_box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox categorie_box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}