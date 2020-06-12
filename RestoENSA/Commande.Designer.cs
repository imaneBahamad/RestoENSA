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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plat_grid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.categorie_box = new MetroFramework.Controls.MetroComboBox();
            this.Commande_grid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.id_table_box = new MetroFramework.Controls.MetroComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.filtre_combobox = new MetroFramework.Controls.MetroComboBox();
            this.prix_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.code_cmd_box = new MetroFramework.Controls.MetroTextBox();
            this.nom_plat_box = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.button4);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.plat_grid);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.categorie_box);
            this.metroPanel1.Controls.Add(this.Commande_grid);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.id_table_box);
            this.metroPanel1.Controls.Add(this.button3);
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.metroLabel22);
            this.metroPanel1.Controls.Add(this.filtre_combobox);
            this.metroPanel1.Controls.Add(this.prix_plat_box);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel20);
            this.metroPanel1.Controls.Add(this.code_cmd_box);
            this.metroPanel1.Controls.Add(this.nom_plat_box);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(847, 364);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 80;
            this.button4.Text = "Vider les Champs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Vider_Champs);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Confirmer Commande";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Confirmer_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.plat_grid.EnableHeadersVisualStyles = false;
            this.plat_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plat_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plat_grid.Location = new System.Drawing.Point(290, 62);
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
            this.plat_grid.RowTemplate.Height = 25;
            this.plat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plat_grid.Size = new System.Drawing.Size(233, 165);
            this.plat_grid.TabIndex = 77;
            this.plat_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plat_grid_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(290, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Plat Par Categorie :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // categorie_box
            // 
            this.categorie_box.FormattingEnabled = true;
            this.categorie_box.ItemHeight = 23;
            this.categorie_box.Items.AddRange(new object[] {
            " "});
            this.categorie_box.Location = new System.Drawing.Point(436, 31);
            this.categorie_box.Name = "categorie_box";
            this.categorie_box.Size = new System.Drawing.Size(87, 29);
            this.categorie_box.TabIndex = 76;
            this.categorie_box.UseSelectable = true;
            this.categorie_box.SelectedIndexChanged += new System.EventHandler(this.categorie_box_SelectedIndexChanged);
            // 
            // Commande_grid
            // 
            this.Commande_grid.AllowUserToOrderColumns = true;
            this.Commande_grid.AllowUserToResizeRows = false;
            this.Commande_grid.BackgroundColor = System.Drawing.Color.Silver;
            this.Commande_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Commande_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Commande_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Commande_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Commande_grid.EnableHeadersVisualStyles = false;
            this.Commande_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Commande_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Commande_grid.Location = new System.Drawing.Point(542, 62);
            this.Commande_grid.Name = "Commande_grid";
            this.Commande_grid.ReadOnly = true;
            this.Commande_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commande_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Commande_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Commande_grid.RowTemplate.Height = 25;
            this.Commande_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Commande_grid.Size = new System.Drawing.Size(302, 165);
            this.Commande_grid.TabIndex = 70;
            this.Commande_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commande_grid_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(5, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "N° de Table :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // id_table_box
            // 
            this.id_table_box.FormattingEnabled = true;
            this.id_table_box.ItemHeight = 23;
            this.id_table_box.Items.AddRange(new object[] {
            " "});
            this.id_table_box.Location = new System.Drawing.Point(144, 135);
            this.id_table_box.Name = "id_table_box";
            this.id_table_box.Size = new System.Drawing.Size(140, 29);
            this.id_table_box.TabIndex = 74;
            this.id_table_box.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 73;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Supprimer_Cmd_Button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
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
            this.metroLabel22.Location = new System.Drawing.Point(553, 29);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(161, 19);
            this.metroLabel22.TabIndex = 71;
            this.metroLabel22.Text = "Commande Par Table :";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // filtre_combobox
            // 
            this.filtre_combobox.FormattingEnabled = true;
            this.filtre_combobox.ItemHeight = 23;
            this.filtre_combobox.Items.AddRange(new object[] {
            " "});
            this.filtre_combobox.Location = new System.Drawing.Point(720, 29);
            this.filtre_combobox.Name = "filtre_combobox";
            this.filtre_combobox.Size = new System.Drawing.Size(124, 29);
            this.filtre_combobox.TabIndex = 69;
            this.filtre_combobox.UseSelectable = true;
            this.filtre_combobox.SelectedIndexChanged += new System.EventHandler(this.filtre_cmd_combobox_SelectedIndexChanged);
            // 
            // prix_plat_box
            // 
            // 
            // 
            // 
            this.prix_plat_box.CustomButton.Image = null;
            this.prix_plat_box.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.prix_plat_box.CustomButton.Name = "";
            this.prix_plat_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prix_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix_plat_box.CustomButton.TabIndex = 1;
            this.prix_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix_plat_box.CustomButton.UseSelectable = true;
            this.prix_plat_box.CustomButton.Visible = false;
            this.prix_plat_box.Enabled = false;
            this.prix_plat_box.Lines = new string[0];
            this.prix_plat_box.Location = new System.Drawing.Point(144, 95);
            this.prix_plat_box.MaxLength = 32767;
            this.prix_plat_box.Name = "prix_plat_box";
            this.prix_plat_box.PasswordChar = '\0';
            this.prix_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix_plat_box.SelectedText = "";
            this.prix_plat_box.SelectionLength = 0;
            this.prix_plat_box.SelectionStart = 0;
            this.prix_plat_box.ShortcutsEnabled = true;
            this.prix_plat_box.Size = new System.Drawing.Size(140, 23);
            this.prix_plat_box.TabIndex = 68;
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
            this.metroLabel15.Location = new System.Drawing.Point(5, 66);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(101, 19);
            this.metroLabel15.TabIndex = 67;
            this.metroLabel15.Text = "Nom du plat :";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(5, 99);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 66;
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
            this.metroLabel20.Location = new System.Drawing.Point(5, 33);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(133, 19);
            this.metroLabel20.TabIndex = 65;
            this.metroLabel20.Text = "Code Commande :";
            this.metroLabel20.UseCustomBackColor = true;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // code_cmd_box
            // 
            this.code_cmd_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.code_cmd_box.CustomButton.Image = null;
            this.code_cmd_box.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.code_cmd_box.CustomButton.Name = "";
            this.code_cmd_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.code_cmd_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.code_cmd_box.CustomButton.TabIndex = 1;
            this.code_cmd_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.code_cmd_box.CustomButton.UseSelectable = true;
            this.code_cmd_box.CustomButton.Visible = false;
            this.code_cmd_box.Enabled = false;
            this.code_cmd_box.Lines = new string[0];
            this.code_cmd_box.Location = new System.Drawing.Point(144, 29);
            this.code_cmd_box.MaxLength = 32767;
            this.code_cmd_box.Name = "code_cmd_box";
            this.code_cmd_box.PasswordChar = '\0';
            this.code_cmd_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code_cmd_box.SelectedText = "";
            this.code_cmd_box.SelectionLength = 0;
            this.code_cmd_box.SelectionStart = 0;
            this.code_cmd_box.ShortcutsEnabled = true;
            this.code_cmd_box.Size = new System.Drawing.Size(140, 23);
            this.code_cmd_box.TabIndex = 64;
            this.code_cmd_box.UseCustomBackColor = true;
            this.code_cmd_box.UseSelectable = true;
            this.code_cmd_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.code_cmd_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nom_plat_box
            // 
            // 
            // 
            // 
            this.nom_plat_box.CustomButton.Image = null;
            this.nom_plat_box.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.nom_plat_box.CustomButton.Name = "";
            this.nom_plat_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom_plat_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_plat_box.CustomButton.TabIndex = 1;
            this.nom_plat_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_plat_box.CustomButton.UseSelectable = true;
            this.nom_plat_box.CustomButton.Visible = false;
            this.nom_plat_box.Enabled = false;
            this.nom_plat_box.Lines = new string[0];
            this.nom_plat_box.Location = new System.Drawing.Point(144, 62);
            this.nom_plat_box.MaxLength = 32767;
            this.nom_plat_box.Name = "nom_plat_box";
            this.nom_plat_box.PasswordChar = '\0';
            this.nom_plat_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_plat_box.SelectedText = "";
            this.nom_plat_box.SelectionLength = 0;
            this.nom_plat_box.SelectionStart = 0;
            this.nom_plat_box.ShortcutsEnabled = true;
            this.nom_plat_box.Size = new System.Drawing.Size(140, 23);
            this.nom_plat_box.TabIndex = 63;
            this.nom_plat_box.UseSelectable = true;
            this.nom_plat_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_plat_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Commande";
            this.Text = "Commande";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plat_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commande_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroGrid plat_grid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox categorie_box;
        private MetroFramework.Controls.MetroGrid Commande_grid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox id_table_box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox filtre_combobox;
        private MetroFramework.Controls.MetroTextBox prix_plat_box;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox code_cmd_box;
        private MetroFramework.Controls.MetroTextBox nom_plat_box;
        private System.Windows.Forms.Button button4;
    }
}