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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plats));
            this.crud_plat_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.disponible_combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.crud_plat_panel.Controls.Add(this.button4);
            this.crud_plat_panel.Controls.Add(this.disponible_combo);
            this.crud_plat_panel.Controls.Add(this.metroLabel2);
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
            this.crud_plat_panel.Location = new System.Drawing.Point(5, 66);
            this.crud_plat_panel.Margin = new System.Windows.Forms.Padding(4);
            this.crud_plat_panel.Name = "crud_plat_panel";
            this.crud_plat_panel.Size = new System.Drawing.Size(1056, 526);
            this.crud_plat_panel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 81;
            this.button4.Text = "Vider les Champs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // disponible_combo
            // 
            this.disponible_combo.FormattingEnabled = true;
            this.disponible_combo.ItemHeight = 24;
            this.disponible_combo.Location = new System.Drawing.Point(170, 201);
            this.disponible_combo.Name = "disponible_combo";
            this.disponible_combo.Size = new System.Drawing.Size(154, 30);
            this.disponible_combo.TabIndex = 64;
            this.disponible_combo.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(25, 211);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "Disponibilité :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(25, 163);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Categorie :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 24;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(170, 153);
            this.categorie_box.Margin = new System.Windows.Forms.Padding(4);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(204, 30);
            this.categorie_box.TabIndex = 61;
            this.categorie_box.UseSelectable = true;
            // 
            // code_plat_box
            // 
            this.code_plat_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.code_plat_box.CustomButton.Image = null;
            this.code_plat_box.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.code_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.code_plat_box.CustomButton.Name = "";
            this.code_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.code_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_plat_box.CustomButton.TabIndex = 1;
            this.code_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_plat_box.CustomButton.UseSelectable = true;
            this.code_plat_box.CustomButton.Visible = false;
            this.code_plat_box.Enabled = false;
            this.code_plat_box.Lines = new string[0];
            this.code_plat_box.Location = new System.Drawing.Point(171, 18);
            this.code_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.code_plat_box.MaxLength = 32767;
            this.code_plat_box.Name = "code_plat_box";
            this.code_plat_box.PasswordChar = '\0';
            this.code_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_plat_box.SelectedText = "";
            this.code_plat_box.SelectionLength = 0;
            this.code_plat_box.SelectionStart = 0;
            this.code_plat_box.ShortcutsEnabled = true;
            this.code_plat_box.Size = new System.Drawing.Size(205, 28);
            this.code_plat_box.TabIndex = 48;
            this.code_plat_box.UseCustomBackColor = true;
            this.code_plat_box.UseSelectable = true;
            this.code_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 60;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.supprimer_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 273);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 59;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.modifier_plat_button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
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
            this.metroLabel5.Location = new System.Drawing.Point(395, 23);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 20);
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
            this.metroLabel22.Location = new System.Drawing.Point(755, 23);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(207, 20);
            this.metroLabel22.TabIndex = 56;
            this.metroLabel22.Text = "Chercher selon la Categorie :";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 24;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(913, 47);
            this.filtre_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(105, 30);
            this.filtre_combobox.TabIndex = 54;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_combobox_SelectedIndexChanged);
            // 
            // plat_grid
            // 
            this.plat_grid.AllowUserToOrderColumns = true;
            this.plat_grid.AllowUserToResizeRows = false;
            this.plat_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plat_grid.BackgroundColor = System.Drawing.Color.White;
            this.plat_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plat_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.plat_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.plat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plat_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.plat_grid.EnableHeadersVisualStyles = false;
            this.plat_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plat_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plat_grid.Location = new System.Drawing.Point(395, 85);
            this.plat_grid.Margin = new System.Windows.Forms.Padding(4);
            this.plat_grid.Name = "plat_grid";
            this.plat_grid.ReadOnly = true;
            this.plat_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
<<<<<<< HEAD
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.plat_grid.RowHeadersWidth = 51;
>>>>>>> 544ada041b62e72a26e877a01af89ffa72433174
            this.plat_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.plat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plat_grid.Size = new System.Drawing.Size(623, 316);
            this.plat_grid.TabIndex = 55;
            this.plat_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plat_grid_CellClick);
<<<<<<< HEAD
            this.plat_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plat_grid_CellContentClick);
=======
>>>>>>> 544ada041b62e72a26e877a01af89ffa72433174
            // 
            // prix_plat_box
            // 
            // 
            // 
            // 
            this.prix_plat_box.CustomButton.Image = null;
            this.prix_plat_box.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.prix_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.prix_plat_box.CustomButton.Name = "";
            this.prix_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.prix_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix_plat_box.CustomButton.TabIndex = 1;
            this.prix_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix_plat_box.CustomButton.UseSelectable = true;
            this.prix_plat_box.CustomButton.Visible = false;
            this.prix_plat_box.Lines = new string[0];
            this.prix_plat_box.Location = new System.Drawing.Point(170, 109);
            this.prix_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.prix_plat_box.MaxLength = 32767;
            this.prix_plat_box.Name = "prix_plat_box";
            this.prix_plat_box.PasswordChar = '\0';
            this.prix_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix_plat_box.SelectedText = "";
            this.prix_plat_box.SelectionLength = 0;
            this.prix_plat_box.SelectionStart = 0;
            this.prix_plat_box.ShortcutsEnabled = true;
            this.prix_plat_box.Size = new System.Drawing.Size(205, 28);
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
            this.metroLabel15.Location = new System.Drawing.Point(25, 72);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(52, 20);
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
            this.metroLabel8.Location = new System.Drawing.Point(25, 117);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 20);
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
            this.metroLabel20.Location = new System.Drawing.Point(25, 26);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(83, 20);
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
            this.nom_plat_box.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.nom_plat_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.nom_plat_box.CustomButton.Name = "";
            this.nom_plat_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nom_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_plat_box.CustomButton.TabIndex = 1;
            this.nom_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_plat_box.CustomButton.UseSelectable = true;
            this.nom_plat_box.CustomButton.Visible = false;
            this.nom_plat_box.Lines = new string[0];
            this.nom_plat_box.Location = new System.Drawing.Point(170, 64);
            this.nom_plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.nom_plat_box.MaxLength = 32767;
            this.nom_plat_box.Name = "nom_plat_box";
            this.nom_plat_box.PasswordChar = '\0';
            this.nom_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_plat_box.SelectedText = "";
            this.nom_plat_box.SelectionLength = 0;
            this.nom_plat_box.SelectionStart = 0;
            this.nom_plat_box.ShortcutsEnabled = true;
            this.nom_plat_box.Size = new System.Drawing.Size(205, 28);
            this.nom_plat_box.TabIndex = 49;
            this.nom_plat_box.UseSelectable = true;
            this.nom_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Quitter_button);
            // 
            // Plats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crud_plat_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plats";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
        private MetroFramework.Controls.MetroComboBox disponible_combo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button button4;
    }
}