namespace RestoENSA
{
    partial class Commande
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.categorie_box = new MetroFramework.Controls.MetroComboBox();
            this.Commande_grid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.id_table_box = new MetroFramework.Controls.MetroComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.filtre_combobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.code_cmd_box = new MetroFramework.Controls.MetroTextBox();
            this.plat_box = new MetroFramework.Controls.MetroComboBox();
            this.quantite_num = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.facture_box = new MetroFramework.Controls.MetroComboBox();
            this.generer_facture_tile = new MetroFramework.Controls.MetroTile();
            this.total_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantite_num)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.quantite_num);
            this.metroPanel1.Controls.Add(this.plat_box);
            this.metroPanel1.Controls.Add(this.button4);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.categorie_box);
            this.metroPanel1.Controls.Add(this.Commande_grid);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.id_table_box);
            this.metroPanel1.Controls.Add(this.button3);
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.metroLabel22);
            this.metroPanel1.Controls.Add(this.filtre_combobox);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.code_cmd_box);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(8, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1180, 409);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 331);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 28);
            this.button4.TabIndex = 80;
            this.button4.Text = "Vider les Champs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Vider_Champs);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 79;
            this.button1.Text = "Confirmer Commande";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Confirmer_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 20);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Catégorie";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 24;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(192, 92);
            this.categorie_box.Margin = new System.Windows.Forms.Padding(4);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(187, 30);
            this.categorie_box.TabIndex = 76;
            this.categorie_box.UseSelectable = true;
            this.categorie_box.SelectedIndexChanged += new System.EventHandler(this.categorie_box_SelectedIndexChanged);
            // 
            // Commande_grid
            // 
            this.Commande_grid.AllowUserToOrderColumns = true;
            this.Commande_grid.AllowUserToResizeRows = false;
            this.Commande_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Commande_grid.BackgroundColor = System.Drawing.Color.White;
            this.Commande_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Commande_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Commande_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Commande_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Commande_grid.EnableHeadersVisualStyles = false;
            this.Commande_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Commande_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Commande_grid.Location = new System.Drawing.Point(443, 56);
            this.Commande_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Commande_grid.Name = "Commande_grid";
            this.Commande_grid.ReadOnly = true;
            this.Commande_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Commande_grid.RowHeadersWidth = 51;
            this.Commande_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Commande_grid.RowTemplate.Height = 25;
            this.Commande_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Commande_grid.Size = new System.Drawing.Size(724, 344);
            this.Commande_grid.TabIndex = 70;
            this.Commande_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commande_grid_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 239);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 20);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "N° de Table";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // id_table_box
            // 
            this.id_table_box.FormattingEnabled = true;
            this.id_table_box.ItemHeight = 24;
            this.id_table_box.Items.AddRange(new object[] {
            " "});
            this.id_table_box.Location = new System.Drawing.Point(192, 229);
            this.id_table_box.Margin = new System.Windows.Forms.Padding(4);
            this.id_table_box.Name = "id_table_box";
            this.id_table_box.Size = new System.Drawing.Size(185, 30);
            this.id_table_box.TabIndex = 74;
            this.id_table_box.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 295);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 73;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Supprimer_Cmd_Button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 295);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 72;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Modifier_Cmd_Click);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel22.Location = new System.Drawing.Point(768, 18);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(165, 20);
            this.metroLabel22.TabIndex = 71;
            this.metroLabel22.Text = "Commande Par Table :";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 24;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(1003, 18);
            this.filtre_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(164, 30);
            this.filtre_combobox.TabIndex = 69;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_cmd_combobox_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel15.Location = new System.Drawing.Point(23, 150);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(36, 20);
            this.metroLabel15.TabIndex = 67;
            this.metroLabel15.Text = "Plat";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // code_cmd_box
            // 
            this.code_cmd_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.code_cmd_box.CustomButton.Image = null;
            this.code_cmd_box.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.code_cmd_box.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.code_cmd_box.CustomButton.Name = "";
            this.code_cmd_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.code_cmd_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_cmd_box.CustomButton.TabIndex = 1;
            this.code_cmd_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_cmd_box.CustomButton.UseSelectable = true;
            this.code_cmd_box.CustomButton.Visible = false;
            this.code_cmd_box.Enabled = false;
            this.code_cmd_box.Lines = new string[0];
            this.code_cmd_box.Location = new System.Drawing.Point(192, 39);
            this.code_cmd_box.Margin = new System.Windows.Forms.Padding(4);
            this.code_cmd_box.MaxLength = 32767;
            this.code_cmd_box.Name = "code_cmd_box";
            this.code_cmd_box.PasswordChar = '\0';
            this.code_cmd_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_cmd_box.SelectedText = "";
            this.code_cmd_box.SelectionLength = 0;
            this.code_cmd_box.SelectionStart = 0;
            this.code_cmd_box.ShortcutsEnabled = true;
            this.code_cmd_box.Size = new System.Drawing.Size(187, 28);
            this.code_cmd_box.TabIndex = 64;
            this.code_cmd_box.UseCustomBackColor = true;
            this.code_cmd_box.UseSelectable = true;
            this.code_cmd_box.Visible = false;
            this.code_cmd_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_cmd_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // plat_box
            // 
            this.plat_box.FormattingEnabled = true;
            this.plat_box.ItemHeight = 24;
            this.plat_box.Items.AddRange(new object[] {
            " "});
            this.plat_box.Location = new System.Drawing.Point(192, 140);
            this.plat_box.Margin = new System.Windows.Forms.Padding(4);
            this.plat_box.Name = "plat_box";
            this.plat_box.Size = new System.Drawing.Size(185, 30);
            this.plat_box.TabIndex = 81;
            this.plat_box.UseSelectable = true;
            // 
            // quantite_num
            // 
            this.quantite_num.Location = new System.Drawing.Point(192, 188);
            this.quantite_num.Name = "quantite_num";
            this.quantite_num.Size = new System.Drawing.Size(185, 22);
            this.quantite_num.TabIndex = 82;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(23, 190);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 20);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Quantité";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(559, 518);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 20);
            this.metroLabel4.TabIndex = 77;
            this.metroLabel4.Text = "N° de Table";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // facture_box
            // 
            this.facture_box.FormattingEnabled = true;
            this.facture_box.ItemHeight = 24;
            this.facture_box.Items.AddRange(new object[] {
            " "});
            this.facture_box.Location = new System.Drawing.Point(684, 518);
            this.facture_box.Margin = new System.Windows.Forms.Padding(4);
            this.facture_box.Name = "facture_box";
            this.facture_box.Size = new System.Drawing.Size(185, 30);
            this.facture_box.TabIndex = 76;
            this.facture_box.UseSelectable = true;
            this.facture_box.SelectedIndexChanged += new System.EventHandler(this.facture_box_SelectedIndexChanged);
            // 
            // generer_facture_tile
            // 
            this.generer_facture_tile.ActiveControl = null;
            this.generer_facture_tile.Location = new System.Drawing.Point(948, 518);
            this.generer_facture_tile.Name = "generer_facture_tile";
            this.generer_facture_tile.Size = new System.Drawing.Size(240, 68);
            this.generer_facture_tile.TabIndex = 78;
            this.generer_facture_tile.Text = "Générer la facture";
            this.generer_facture_tile.UseSelectable = true;
            this.generer_facture_tile.Click += new System.EventHandler(this.generer_facture_tile_Click);
            // 
            // total_txt
            // 
            // 
            // 
            // 
            this.total_txt.CustomButton.Image = null;
            this.total_txt.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.total_txt.CustomButton.Name = "";
            this.total_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.total_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.total_txt.CustomButton.TabIndex = 1;
            this.total_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total_txt.CustomButton.UseSelectable = true;
            this.total_txt.CustomButton.Visible = false;
            this.total_txt.Enabled = false;
            this.total_txt.Lines = new string[0];
            this.total_txt.Location = new System.Drawing.Point(684, 563);
            this.total_txt.MaxLength = 32767;
            this.total_txt.Name = "total_txt";
            this.total_txt.PasswordChar = '\0';
            this.total_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total_txt.SelectedText = "";
            this.total_txt.SelectionLength = 0;
            this.total_txt.SelectionStart = 0;
            this.total_txt.ShortcutsEnabled = true;
            this.total_txt.Size = new System.Drawing.Size(185, 23);
            this.total_txt.TabIndex = 79;
            this.total_txt.UseSelectable = true;
            this.total_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.total_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(559, 563);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 20);
            this.metroLabel5.TabIndex = 80;
            this.metroLabel5.Text = "Total";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(872, 565);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 20);
            this.metroLabel6.TabIndex = 81;
            this.metroLabel6.Text = "DH";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 634);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.generer_facture_tile);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.facture_box);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Commande";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantite_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox categorie_box;
        private MetroFramework.Controls.MetroGrid Commande_grid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox id_table_box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox filtre_combobox;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox code_cmd_box;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroComboBox plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown quantite_num;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox facture_box;
        private MetroFramework.Controls.MetroTile generer_facture_tile;
        private MetroFramework.Controls.MetroTextBox total_txt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}