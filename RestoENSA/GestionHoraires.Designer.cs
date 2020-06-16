namespace RestoENSA
{
    partial class GestionHoraires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionHoraires));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.retour_btn = new System.Windows.Forms.Button();
            this.ajout_btn = new MetroFramework.Controls.MetroButton();
            this.modif_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_btn = new MetroFramework.Controls.MetroButton();
            this.vider_btn = new MetroFramework.Controls.MetroButton();
            this.debut_sem_label = new MetroFramework.Controls.MetroLabel();
            this.fin_sem_label = new MetroFramework.Controls.MetroLabel();
            this.shift1_label = new MetroFramework.Controls.MetroLabel();
            this.shift2_label = new MetroFramework.Controls.MetroLabel();
            this.debut_time = new MetroFramework.Controls.MetroDateTime();
            this.fin_time = new MetroFramework.Controls.MetroDateTime();
            this.shift1_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.shift2_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.Horaire_grid = new MetroFramework.Controls.MetroGrid();
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.nomChef_label = new MetroFramework.Controls.MetroLabel();
            this.nomServeur_label = new MetroFramework.Controls.MetroLabel();
            this.chef_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.serveur_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.show_chef_btn = new MetroFramework.Controls.MetroButton();
            this.show_serveur_btn = new MetroFramework.Controls.MetroButton();
            this.affecter_chef_btn = new MetroFramework.Controls.MetroButton();
            this.affecter_serveur_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Horaire_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(26, 63);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(59, 54);
            this.retour_btn.TabIndex = 18;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // ajout_btn
            // 
            this.ajout_btn.Location = new System.Drawing.Point(81, 400);
            this.ajout_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajout_btn.Name = "ajout_btn";
            this.ajout_btn.Size = new System.Drawing.Size(100, 28);
            this.ajout_btn.TabIndex = 19;
            this.ajout_btn.Text = "Ajouter";
            this.ajout_btn.UseSelectable = true;
            this.ajout_btn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // modif_btn
            // 
            this.modif_btn.Location = new System.Drawing.Point(189, 400);
            this.modif_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(100, 28);
            this.modif_btn.TabIndex = 20;
            this.modif_btn.Text = "Modifier";
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.modif_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.Location = new System.Drawing.Point(297, 400);
            this.supprimer_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(100, 28);
            this.supprimer_btn.TabIndex = 21;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // vider_btn
            // 
            this.vider_btn.Location = new System.Drawing.Point(162, 435);
            this.vider_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(157, 28);
            this.vider_btn.TabIndex = 22;
            this.vider_btn.Text = "Vider les champs";
            this.vider_btn.UseSelectable = true;
            this.vider_btn.Click += new System.EventHandler(this.vider_btn_Click);
            // 
            // debut_sem_label
            // 
            this.debut_sem_label.AutoSize = true;
            this.debut_sem_label.Location = new System.Drawing.Point(68, 189);
            this.debut_sem_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debut_sem_label.Name = "debut_sem_label";
            this.debut_sem_label.Size = new System.Drawing.Size(123, 20);
            this.debut_sem_label.TabIndex = 23;
            this.debut_sem_label.Text = "Debut de semaine";
            // 
            // fin_sem_label
            // 
            this.fin_sem_label.AutoSize = true;
            this.fin_sem_label.Location = new System.Drawing.Point(68, 239);
            this.fin_sem_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fin_sem_label.Name = "fin_sem_label";
            this.fin_sem_label.Size = new System.Drawing.Size(103, 20);
            this.fin_sem_label.TabIndex = 24;
            this.fin_sem_label.Text = "Fin de semaine";
            // 
            // shift1_label
            // 
            this.shift1_label.AutoSize = true;
            this.shift1_label.Location = new System.Drawing.Point(68, 288);
            this.shift1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shift1_label.Name = "shift1_label";
            this.shift1_label.Size = new System.Drawing.Size(90, 20);
            this.shift1_label.TabIndex = 25;
            this.shift1_label.Text = "Horaire Shift1";
            // 
            // shift2_label
            // 
            this.shift2_label.AutoSize = true;
            this.shift2_label.Location = new System.Drawing.Point(68, 336);
            this.shift2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shift2_label.Name = "shift2_label";
            this.shift2_label.Size = new System.Drawing.Size(92, 20);
            this.shift2_label.TabIndex = 26;
            this.shift2_label.Text = "Horaire shift2";
            // 
            // debut_time
            // 
            this.debut_time.CustomFormat = "dd-MM-yyyy";
            this.debut_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.debut_time.Location = new System.Drawing.Point(259, 189);
            this.debut_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debut_time.MinimumSize = new System.Drawing.Size(0, 30);
            this.debut_time.Name = "debut_time";
            this.debut_time.Size = new System.Drawing.Size(159, 30);
            this.debut_time.TabIndex = 27;
            this.debut_time.Value = new System.DateTime(2020, 6, 13, 0, 0, 0, 0);
            // 
            // fin_time
            // 
            this.fin_time.CustomFormat = "dd-MM-yyyy";
            this.fin_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fin_time.Location = new System.Drawing.Point(259, 239);
            this.fin_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fin_time.MinimumSize = new System.Drawing.Size(0, 30);
            this.fin_time.Name = "fin_time";
            this.fin_time.Size = new System.Drawing.Size(159, 30);
            this.fin_time.TabIndex = 28;
            // 
            // shift1_comboBox
            // 
            this.shift1_comboBox.FormattingEnabled = true;
            this.shift1_comboBox.ItemHeight = 24;
            this.shift1_comboBox.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00",
            "21:00:00",
            "21:30:00",
            "22:00:00",
            "22:30:00",
            "23:00:00",
            "23:30:00",
            "00:00:00",
            "00:30:00",
            "01:00:00",
            "01:30:00",
            "02:00:00",
            "02:30:00",
            "03:00:00",
            "03:30:00",
            "04:00:00",
            "04:30:00",
            "05:00:00",
            "05:30:00",
            "06:00:00",
            "06:30:00",
            "07:00:00",
            "07:30:00",
            "",
            ""});
            this.shift1_comboBox.Location = new System.Drawing.Point(260, 288);
            this.shift1_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shift1_comboBox.Name = "shift1_comboBox";
            this.shift1_comboBox.Size = new System.Drawing.Size(159, 30);
            this.shift1_comboBox.TabIndex = 29;
            this.shift1_comboBox.UseSelectable = true;
            // 
            // shift2_comboBox
            // 
            this.shift2_comboBox.FormattingEnabled = true;
            this.shift2_comboBox.ItemHeight = 24;
            this.shift2_comboBox.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00",
            "21:00:00",
            "21:30:00",
            "22:00:00",
            "22:30:00",
            "23:00:00",
            "23:30:00",
            "00:00:00",
            "00:30:00",
            "01:00:00",
            "01:30:00",
            "02:00:00",
            "02:30:00",
            "03:00:00",
            "03:30:00",
            "04:00:00",
            "04:30:00",
            "05:00:00",
            "05:30:00",
            "06:00:00",
            "06:30:00",
            "07:00:00",
            "07:30:00"});
            this.shift2_comboBox.Location = new System.Drawing.Point(260, 336);
            this.shift2_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shift2_comboBox.Name = "shift2_comboBox";
            this.shift2_comboBox.Size = new System.Drawing.Size(159, 30);
            this.shift2_comboBox.TabIndex = 30;
            this.shift2_comboBox.UseSelectable = true;
            // 
            // Horaire_grid
            // 
            this.Horaire_grid.AllowUserToResizeRows = false;
            this.Horaire_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Horaire_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Horaire_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Horaire_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Horaire_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Horaire_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Horaire_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Horaire_grid.EnableHeadersVisualStyles = false;
            this.Horaire_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Horaire_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Horaire_grid.Location = new System.Drawing.Point(457, 119);
            this.Horaire_grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Horaire_grid.Name = "Horaire_grid";
            this.Horaire_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Horaire_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Horaire_grid.RowHeadersWidth = 51;
            this.Horaire_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Horaire_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Horaire_grid.Size = new System.Drawing.Size(588, 206);
            this.Horaire_grid.TabIndex = 31;
            this.Horaire_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Horaire_grid_CellClick);
            // 
            // numero_txt
            // 
            // 
            // 
            // 
            this.numero_txt.CustomButton.Image = null;
            this.numero_txt.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.numero_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numero_txt.CustomButton.Name = "";
            this.numero_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.numero_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.numero_txt.CustomButton.TabIndex = 1;
            this.numero_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.numero_txt.CustomButton.UseSelectable = true;
            this.numero_txt.CustomButton.Visible = false;
            this.numero_txt.Lines = new string[0];
            this.numero_txt.Location = new System.Drawing.Point(259, 119);
            this.numero_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numero_txt.MaxLength = 32767;
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.PasswordChar = '\0';
            this.numero_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numero_txt.SelectedText = "";
            this.numero_txt.SelectionLength = 0;
            this.numero_txt.SelectionStart = 0;
            this.numero_txt.ShortcutsEnabled = true;
            this.numero_txt.Size = new System.Drawing.Size(160, 28);
            this.numero_txt.TabIndex = 32;
            this.numero_txt.UseSelectable = true;
            this.numero_txt.Visible = false;
            this.numero_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numero_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nomChef_label
            // 
            this.nomChef_label.AutoSize = true;
            this.nomChef_label.Location = new System.Drawing.Point(625, 417);
            this.nomChef_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomChef_label.Name = "nomChef_label";
            this.nomChef_label.Size = new System.Drawing.Size(73, 20);
            this.nomChef_label.TabIndex = 33;
            this.nomChef_label.Text = "Nom Chef";
            this.nomChef_label.Visible = false;
            // 
            // nomServeur_label
            // 
            this.nomServeur_label.AutoSize = true;
            this.nomServeur_label.Location = new System.Drawing.Point(859, 417);
            this.nomServeur_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomServeur_label.Name = "nomServeur_label";
            this.nomServeur_label.Size = new System.Drawing.Size(93, 20);
            this.nomServeur_label.TabIndex = 34;
            this.nomServeur_label.Text = "Nom Serveur";
            this.nomServeur_label.Visible = false;
            // 
            // chef_comboBox
            // 
            this.chef_comboBox.FormattingEnabled = true;
            this.chef_comboBox.ItemHeight = 24;
            this.chef_comboBox.Location = new System.Drawing.Point(625, 453);
            this.chef_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chef_comboBox.Name = "chef_comboBox";
            this.chef_comboBox.Size = new System.Drawing.Size(172, 30);
            this.chef_comboBox.TabIndex = 35;
            this.chef_comboBox.UseSelectable = true;
            this.chef_comboBox.Visible = false;
            this.chef_comboBox.SelectedIndexChanged += new System.EventHandler(this.chef_comboBox_SelectedIndexChanged);
            // 
            // serveur_comboBox
            // 
            this.serveur_comboBox.FormattingEnabled = true;
            this.serveur_comboBox.ItemHeight = 24;
            this.serveur_comboBox.Location = new System.Drawing.Point(859, 453);
            this.serveur_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serveur_comboBox.Name = "serveur_comboBox";
            this.serveur_comboBox.Size = new System.Drawing.Size(176, 30);
            this.serveur_comboBox.TabIndex = 36;
            this.serveur_comboBox.UseSelectable = true;
            this.serveur_comboBox.Visible = false;
            // 
            // show_chef_btn
            // 
            this.show_chef_btn.Location = new System.Drawing.Point(625, 356);
            this.show_chef_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_chef_btn.Name = "show_chef_btn";
            this.show_chef_btn.Size = new System.Drawing.Size(160, 47);
            this.show_chef_btn.TabIndex = 37;
            this.show_chef_btn.Text = "Affecter à Chef";
            this.show_chef_btn.UseSelectable = true;
            this.show_chef_btn.Click += new System.EventHandler(this.show_chef_btn_Click);
            // 
            // show_serveur_btn
            // 
            this.show_serveur_btn.Location = new System.Drawing.Point(859, 356);
            this.show_serveur_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_serveur_btn.Name = "show_serveur_btn";
            this.show_serveur_btn.Size = new System.Drawing.Size(147, 47);
            this.show_serveur_btn.TabIndex = 38;
            this.show_serveur_btn.Text = "Affecter à Serveur";
            this.show_serveur_btn.UseSelectable = true;
            this.show_serveur_btn.Click += new System.EventHandler(this.show_serveur_btn_Click);
            // 
            // affecter_chef_btn
            // 
            this.affecter_chef_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.affecter_chef_btn.Location = new System.Drawing.Point(697, 497);
            this.affecter_chef_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.affecter_chef_btn.Name = "affecter_chef_btn";
            this.affecter_chef_btn.Size = new System.Drawing.Size(100, 28);
            this.affecter_chef_btn.TabIndex = 39;
            this.affecter_chef_btn.Text = "Affecter";
            this.affecter_chef_btn.UseCustomBackColor = true;
            this.affecter_chef_btn.UseSelectable = true;
            this.affecter_chef_btn.Visible = false;
            this.affecter_chef_btn.Click += new System.EventHandler(this.affecter_chef_btn_Click);
            // 
            // affecter_serveur_btn
            // 
            this.affecter_serveur_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.affecter_serveur_btn.Location = new System.Drawing.Point(936, 497);
            this.affecter_serveur_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.affecter_serveur_btn.Name = "affecter_serveur_btn";
            this.affecter_serveur_btn.Size = new System.Drawing.Size(100, 28);
            this.affecter_serveur_btn.TabIndex = 40;
            this.affecter_serveur_btn.Text = "Affecter";
            this.affecter_serveur_btn.UseCustomBackColor = true;
            this.affecter_serveur_btn.UseSelectable = true;
            this.affecter_serveur_btn.Visible = false;
            this.affecter_serveur_btn.Click += new System.EventHandler(this.affecter_serveur_btn_Click);
            // 
            // GestionHoraires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.affecter_serveur_btn);
            this.Controls.Add(this.affecter_chef_btn);
            this.Controls.Add(this.show_serveur_btn);
            this.Controls.Add(this.show_chef_btn);
            this.Controls.Add(this.serveur_comboBox);
            this.Controls.Add(this.chef_comboBox);
            this.Controls.Add(this.nomServeur_label);
            this.Controls.Add(this.nomChef_label);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.Horaire_grid);
            this.Controls.Add(this.shift2_comboBox);
            this.Controls.Add(this.shift1_comboBox);
            this.Controls.Add(this.fin_time);
            this.Controls.Add(this.debut_time);
            this.Controls.Add(this.shift2_label);
            this.Controls.Add(this.shift1_label);
            this.Controls.Add(this.fin_sem_label);
            this.Controls.Add(this.debut_sem_label);
            this.Controls.Add(this.vider_btn);
            this.Controls.Add(this.supprimer_btn);
            this.Controls.Add(this.modif_btn);
            this.Controls.Add(this.ajout_btn);
            this.Controls.Add(this.retour_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionHoraires";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "GestionHoraires";
            ((System.ComponentModel.ISupportInitialize)(this.Horaire_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retour_btn;
        private MetroFramework.Controls.MetroButton ajout_btn;
        private MetroFramework.Controls.MetroButton modif_btn;
        private MetroFramework.Controls.MetroButton supprimer_btn;
        private MetroFramework.Controls.MetroButton vider_btn;
        private MetroFramework.Controls.MetroLabel debut_sem_label;
        private MetroFramework.Controls.MetroLabel fin_sem_label;
        private MetroFramework.Controls.MetroLabel shift1_label;
        private MetroFramework.Controls.MetroLabel shift2_label;
        private MetroFramework.Controls.MetroDateTime debut_time;
        private MetroFramework.Controls.MetroDateTime fin_time;
        private MetroFramework.Controls.MetroComboBox shift1_comboBox;
        private MetroFramework.Controls.MetroComboBox shift2_comboBox;
        private MetroFramework.Controls.MetroGrid Horaire_grid;
        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel nomChef_label;
        private MetroFramework.Controls.MetroLabel nomServeur_label;
        private MetroFramework.Controls.MetroComboBox chef_comboBox;
        private MetroFramework.Controls.MetroComboBox serveur_comboBox;
        private MetroFramework.Controls.MetroButton show_chef_btn;
        private MetroFramework.Controls.MetroButton show_serveur_btn;
        private MetroFramework.Controls.MetroButton affecter_chef_btn;
        private MetroFramework.Controls.MetroButton affecter_serveur_btn;
    }
}