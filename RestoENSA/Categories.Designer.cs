namespace RestoENSA
{
    partial class Categories
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
            this.PanelInfo = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.categorie_nom_box = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Categorie_grid = new MetroFramework.Controls.MetroGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.categorie_code_box = new MetroFramework.Controls.MetroTextBox();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorie_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo.Controls.Add(this.button4);
            this.PanelInfo.Controls.Add(this.categorie_nom_box);
            this.PanelInfo.Controls.Add(this.button3);
            this.PanelInfo.Controls.Add(this.metroLabel1);
            this.PanelInfo.Controls.Add(this.Categorie_grid);
            this.PanelInfo.Controls.Add(this.button2);
            this.PanelInfo.Controls.Add(this.button1);
            this.PanelInfo.Controls.Add(this.metroLabel20);
            this.PanelInfo.Controls.Add(this.categorie_code_box);
            this.PanelInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelInfo.HorizontalScrollbarBarColor = true;
            this.PanelInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelInfo.HorizontalScrollbarSize = 10;
            this.PanelInfo.Location = new System.Drawing.Point(23, 63);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(768, 239);
            this.PanelInfo.TabIndex = 43;
            this.PanelInfo.UseCustomBackColor = true;
            this.PanelInfo.UseCustomForeColor = true;
            this.PanelInfo.UseStyleColors = true;
            this.PanelInfo.VerticalScrollbarBarColor = true;
            this.PanelInfo.VerticalScrollbarHighlightOnWheel = false;
            this.PanelInfo.VerticalScrollbarSize = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 155);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 19);
            this.button4.TabIndex = 81;
            this.button4.Text = "Vider les Champs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // categorie_nom_box
            // 
            // 
            // 
            // 
            this.categorie_nom_box.CustomButton.Image = null;
            this.categorie_nom_box.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.categorie_nom_box.CustomButton.Name = "";
            this.categorie_nom_box.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.categorie_nom_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorie_nom_box.CustomButton.TabIndex = 1;
            this.categorie_nom_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorie_nom_box.CustomButton.UseSelectable = true;
            this.categorie_nom_box.CustomButton.Visible = false;
            this.categorie_nom_box.Lines = new string[0];
            this.categorie_nom_box.Location = new System.Drawing.Point(136, 54);
            this.categorie_nom_box.MaxLength = 32767;
            this.categorie_nom_box.Name = "categorie_nom_box";
            this.categorie_nom_box.PasswordChar = '\0';
            this.categorie_nom_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorie_nom_box.SelectedText = "";
            this.categorie_nom_box.SelectionLength = 0;
            this.categorie_nom_box.SelectionStart = 0;
            this.categorie_nom_box.ShortcutsEnabled = true;
            this.categorie_nom_box.Size = new System.Drawing.Size(115, 19);
            this.categorie_nom_box.TabIndex = 40;
            this.categorie_nom_box.UseSelectable = true;
            this.categorie_nom_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorie_nom_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.modifier_categorie_button);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(3, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Nom Categorie :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // Categorie_grid
            // 
            this.Categorie_grid.AllowUserToOrderColumns = true;
            this.Categorie_grid.AllowUserToResizeRows = false;
            this.Categorie_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Categorie_grid.BackgroundColor = System.Drawing.Color.White;
            this.Categorie_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Categorie_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Categorie_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categorie_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Categorie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Categorie_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Categorie_grid.EnableHeadersVisualStyles = false;
            this.Categorie_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Categorie_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Categorie_grid.Location = new System.Drawing.Point(298, 13);
            this.Categorie_grid.Name = "Categorie_grid";
            this.Categorie_grid.ReadOnly = true;
            this.Categorie_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categorie_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Categorie_grid.RowHeadersWidth = 51;
            this.Categorie_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Categorie_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Categorie_grid.Size = new System.Drawing.Size(456, 210);
            this.Categorie_grid.TabIndex = 36;
            this.Categorie_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Categorie_grid_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.supprimer_categorie_button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ajouter_categorie_button);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel20.Location = new System.Drawing.Point(0, 13);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(126, 19);
            this.metroLabel20.TabIndex = 33;
            this.metroLabel20.Text = "Code Categorie  :";
            this.metroLabel20.UseCustomBackColor = true;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // categorie_code_box
            // 
            this.categorie_code_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.categorie_code_box.CustomButton.Image = null;
            this.categorie_code_box.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.categorie_code_box.CustomButton.Name = "";
            this.categorie_code_box.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.categorie_code_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorie_code_box.CustomButton.TabIndex = 1;
            this.categorie_code_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorie_code_box.CustomButton.UseSelectable = true;
            this.categorie_code_box.CustomButton.Visible = false;
            this.categorie_code_box.Enabled = false;
            this.categorie_code_box.Lines = new string[0];
            this.categorie_code_box.Location = new System.Drawing.Point(136, 13);
            this.categorie_code_box.MaxLength = 32767;
            this.categorie_code_box.Name = "categorie_code_box";
            this.categorie_code_box.PasswordChar = '\0';
            this.categorie_code_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorie_code_box.SelectedText = "";
            this.categorie_code_box.SelectionLength = 0;
            this.categorie_code_box.SelectionStart = 0;
            this.categorie_code_box.ShortcutsEnabled = true;
            this.categorie_code_box.Size = new System.Drawing.Size(154, 23);
            this.categorie_code_box.TabIndex = 15;
            this.categorie_code_box.UseCustomBackColor = true;
            this.categorie_code_box.UseSelectable = true;
            this.categorie_code_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorie_code_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.PanelInfo);
            this.Name = "Categories";
            this.Text = "Categorie";
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorie_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelInfo;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox categorie_code_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroGrid Categorie_grid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTextBox categorie_nom_box;
        private System.Windows.Forms.Button button4;
    }
}