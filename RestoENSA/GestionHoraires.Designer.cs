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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.retour_btn.Location = new System.Drawing.Point(31, 76);
            this.retour_btn.Margin = new System.Windows.Forms.Padding(2);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(44, 44);
            this.retour_btn.TabIndex = 18;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // ajout_btn
            // 
            this.ajout_btn.Location = new System.Drawing.Point(62, 345);
            this.ajout_btn.Name = "ajout_btn";
            this.ajout_btn.Size = new System.Drawing.Size(75, 23);
            this.ajout_btn.TabIndex = 19;
            this.ajout_btn.Text = "Ajouter";
            this.ajout_btn.UseSelectable = true;
            this.ajout_btn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // modif_btn
            // 
            this.modif_btn.Location = new System.Drawing.Point(143, 345);
            this.modif_btn.Name = "modif_btn";
            this.modif_btn.Size = new System.Drawing.Size(75, 23);
            this.modif_btn.TabIndex = 20;
            this.modif_btn.Text = "Modifier";
            this.modif_btn.UseSelectable = true;
            this.modif_btn.Click += new System.EventHandler(this.modif_btn_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.Location = new System.Drawing.Point(224, 345);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(75, 23);
            this.supprimer_btn.TabIndex = 21;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseSelectable = true;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // vider_btn
            // 
            this.vider_btn.Location = new System.Drawing.Point(123, 374);
            this.vider_btn.Name = "vider_btn";
            this.vider_btn.Size = new System.Drawing.Size(118, 23);
            this.vider_btn.TabIndex = 22;
            this.vider_btn.Text = "Vider les champs";
            this.vider_btn.UseSelectable = true;
            this.vider_btn.Click += new System.EventHandler(this.vider_btn_Click);
            // 
            // debut_sem_label
            // 
            this.debut_sem_label.AutoSize = true;
            this.debut_sem_label.Location = new System.Drawing.Point(51, 148);
            this.debut_sem_label.Name = "debut_sem_label";
            this.debut_sem_label.Size = new System.Drawing.Size(115, 19);
            this.debut_sem_label.TabIndex = 23;
            this.debut_sem_label.Text = "Debut de semaine";
            // 
            // fin_sem_label
            // 
            this.fin_sem_label.AutoSize = true;
            this.fin_sem_label.Location = new System.Drawing.Point(51, 189);
            this.fin_sem_label.Name = "fin_sem_label";
            this.fin_sem_label.Size = new System.Drawing.Size(97, 19);
            this.fin_sem_label.TabIndex = 24;
            this.fin_sem_label.Text = "Fin de semaine";
            // 
            // shift1_label
            // 
            this.shift1_label.AutoSize = true;
            this.shift1_label.Location = new System.Drawing.Point(51, 233);
            this.shift1_label.Name = "shift1_label";
            this.shift1_label.Size = new System.Drawing.Size(89, 57);
            this.shift1_label.TabIndex = 25;
            this.shift1_label.Text = "Horaire Shift1\r\n(Debut)\r\n";
            // 
            // shift2_label
            // 
            this.shift2_label.AutoSize = true;
            this.shift2_label.Location = new System.Drawing.Point(51, 279);
            this.shift2_label.Name = "shift2_label";
            this.shift2_label.Size = new System.Drawing.Size(87, 38);
            this.shift2_label.TabIndex = 26;
            this.shift2_label.Text = "Horaire shift2\r\n(Fin)";
            // 
            // debut_time
            // 
            this.debut_time.CustomFormat = "dd-MM-yyyy";
            this.debut_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.debut_time.Location = new System.Drawing.Point(194, 138);
            this.debut_time.MinimumSize = new System.Drawing.Size(0, 29);
            this.debut_time.Name = "debut_time";
            this.debut_time.Size = new System.Drawing.Size(120, 29);
            this.debut_time.TabIndex = 27;
            this.debut_time.Value = new System.DateTime(2020, 6, 13, 0, 0, 0, 0);
            // 
            // fin_time
            // 
            this.fin_time.CustomFormat = "dd-MM-yyyy";
            this.fin_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fin_time.Location = new System.Drawing.Point(194, 179);
            this.fin_time.MinimumSize = new System.Drawing.Size(0, 29);
            this.fin_time.Name = "fin_time";
            this.fin_time.Size = new System.Drawing.Size(120, 29);
            this.fin_time.TabIndex = 28;
            // 
            // shift1_comboBox
            // 
            this.shift1_comboBox.FormattingEnabled = true;
            this.shift1_comboBox.ItemHeight = 23;
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
            this.shift1_comboBox.Location = new System.Drawing.Point(194, 235);
            this.shift1_comboBox.Name = "shift1_comboBox";
            this.shift1_comboBox.Size = new System.Drawing.Size(120, 29);
            this.shift1_comboBox.TabIndex = 29;
            this.shift1_comboBox.UseSelectable = true;
            // 
            // shift2_comboBox
            // 
            this.shift2_comboBox.FormattingEnabled = true;
            this.shift2_comboBox.ItemHeight = 23;
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
            this.shift2_comboBox.Location = new System.Drawing.Point(194, 289);
            this.shift2_comboBox.Name = "shift2_comboBox";
            this.shift2_comboBox.Size = new System.Drawing.Size(120, 29);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Horaire_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Horaire_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Horaire_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Horaire_grid.EnableHeadersVisualStyles = false;
            this.Horaire_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Horaire_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Horaire_grid.Location = new System.Drawing.Point(343, 97);
            this.Horaire_grid.Name = "Horaire_grid";
            this.Horaire_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Horaire_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Horaire_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Horaire_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Horaire_grid.Size = new System.Drawing.Size(441, 167);
            this.Horaire_grid.TabIndex = 31;
            this.Horaire_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Horaire_grid_CellClick);
            // 
            // numero_txt
            // 
            // 
            // 
            // 
            this.numero_txt.CustomButton.Image = null;
            this.numero_txt.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.numero_txt.CustomButton.Name = "";
            this.numero_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.numero_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.numero_txt.CustomButton.TabIndex = 1;
            this.numero_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.numero_txt.CustomButton.UseSelectable = true;
            this.numero_txt.CustomButton.Visible = false;
            this.numero_txt.Lines = new string[0];
            this.numero_txt.Location = new System.Drawing.Point(197, 97);
            this.numero_txt.MaxLength = 32767;
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.PasswordChar = '\0';
            this.numero_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numero_txt.SelectedText = "";
            this.numero_txt.SelectionLength = 0;
            this.numero_txt.SelectionStart = 0;
            this.numero_txt.ShortcutsEnabled = true;
            this.numero_txt.Size = new System.Drawing.Size(117, 23);
            this.numero_txt.TabIndex = 32;
            this.numero_txt.UseSelectable = true;
            this.numero_txt.Visible = false;
            this.numero_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numero_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nomChef_label
            // 
            this.nomChef_label.AutoSize = true;
            this.nomChef_label.Location = new System.Drawing.Point(469, 339);
            this.nomChef_label.Name = "nomChef_label";
            this.nomChef_label.Size = new System.Drawing.Size(70, 19);
            this.nomChef_label.TabIndex = 33;
            this.nomChef_label.Text = "Nom Chef";
            this.nomChef_label.Visible = false;
            // 
            // nomServeur_label
            // 
            this.nomServeur_label.AutoSize = true;
            this.nomServeur_label.Location = new System.Drawing.Point(644, 339);
            this.nomServeur_label.Name = "nomServeur_label";
            this.nomServeur_label.Size = new System.Drawing.Size(87, 19);
            this.nomServeur_label.TabIndex = 34;
            this.nomServeur_label.Text = "Nom Serveur";
            this.nomServeur_label.Visible = false;
            // 
            // chef_comboBox
            // 
            this.chef_comboBox.FormattingEnabled = true;
            this.chef_comboBox.ItemHeight = 23;
            this.chef_comboBox.Location = new System.Drawing.Point(469, 368);
            this.chef_comboBox.Name = "chef_comboBox";
            this.chef_comboBox.Size = new System.Drawing.Size(130, 29);
            this.chef_comboBox.TabIndex = 35;
            this.chef_comboBox.UseSelectable = true;
            this.chef_comboBox.Visible = false;
            this.chef_comboBox.SelectedIndexChanged += new System.EventHandler(this.chef_comboBox_SelectedIndexChanged);
            // 
            // serveur_comboBox
            // 
            this.serveur_comboBox.FormattingEnabled = true;
            this.serveur_comboBox.ItemHeight = 23;
            this.serveur_comboBox.Location = new System.Drawing.Point(644, 368);
            this.serveur_comboBox.Name = "serveur_comboBox";
            this.serveur_comboBox.Size = new System.Drawing.Size(133, 29);
            this.serveur_comboBox.TabIndex = 36;
            this.serveur_comboBox.UseSelectable = true;
            this.serveur_comboBox.Visible = false;
            // 
            // show_chef_btn
            // 
            this.show_chef_btn.Location = new System.Drawing.Point(469, 289);
            this.show_chef_btn.Name = "show_chef_btn";
            this.show_chef_btn.Size = new System.Drawing.Size(120, 38);
            this.show_chef_btn.TabIndex = 37;
            this.show_chef_btn.Text = "Affecteer à Chef";
            this.show_chef_btn.UseSelectable = true;
            this.show_chef_btn.Click += new System.EventHandler(this.show_chef_btn_Click);
            // 
            // show_serveur_btn
            // 
            this.show_serveur_btn.Location = new System.Drawing.Point(644, 289);
            this.show_serveur_btn.Name = "show_serveur_btn";
            this.show_serveur_btn.Size = new System.Drawing.Size(110, 38);
            this.show_serveur_btn.TabIndex = 38;
            this.show_serveur_btn.Text = "Affecter à Serveur";
            this.show_serveur_btn.UseSelectable = true;
            this.show_serveur_btn.Click += new System.EventHandler(this.show_serveur_btn_Click);
            // 
            // affecter_chef_btn
            // 
            this.affecter_chef_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.affecter_chef_btn.Location = new System.Drawing.Point(523, 404);
            this.affecter_chef_btn.Name = "affecter_chef_btn";
            this.affecter_chef_btn.Size = new System.Drawing.Size(75, 23);
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
            this.affecter_serveur_btn.Location = new System.Drawing.Point(702, 404);
            this.affecter_serveur_btn.Name = "affecter_serveur_btn";
            this.affecter_serveur_btn.Size = new System.Drawing.Size(75, 23);
            this.affecter_serveur_btn.TabIndex = 40;
            this.affecter_serveur_btn.Text = "Affecter";
            this.affecter_serveur_btn.UseCustomBackColor = true;
            this.affecter_serveur_btn.UseSelectable = true;
            this.affecter_serveur_btn.Visible = false;
            this.affecter_serveur_btn.Click += new System.EventHandler(this.affecter_serveur_btn_Click);
            // 
            // GestionHoraires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "GestionHoraires";
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