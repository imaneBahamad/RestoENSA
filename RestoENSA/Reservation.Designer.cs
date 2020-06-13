namespace RestoENSA
{
    partial class Reservation
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
            this.id_txt = new MetroFramework.Controls.MetroTextBox();
            this.id_lbl = new MetroFramework.Controls.MetroLabel();
            this.reserver_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_txt = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            // 
            // 
            // 
            this.id_txt.CustomButton.Image = null;
            this.id_txt.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.id_txt.CustomButton.Name = "";
            this.id_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_txt.CustomButton.TabIndex = 1;
            this.id_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_txt.CustomButton.UseSelectable = true;
            this.id_txt.CustomButton.Visible = false;
            this.id_txt.Lines = new string[0];
            this.id_txt.Location = new System.Drawing.Point(243, 159);
            this.id_txt.MaxLength = 32767;
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '\0';
            this.id_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_txt.SelectedText = "";
            this.id_txt.SelectionLength = 0;
            this.id_txt.SelectionStart = 0;
            this.id_txt.ShortcutsEnabled = true;
            this.id_txt.Size = new System.Drawing.Size(200, 23);
            this.id_txt.TabIndex = 0;
            this.id_txt.UseSelectable = true;
            this.id_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(76, 162);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(129, 20);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "Numéro de la table";
            // 
            // reserver_btn
            // 
            this.reserver_btn.Location = new System.Drawing.Point(91, 242);
            this.reserver_btn.Name = "reserver_btn";
            this.reserver_btn.Size = new System.Drawing.Size(103, 23);
            this.reserver_btn.TabIndex = 2;
            this.reserver_btn.Text = "Réserver";
            this.reserver_btn.UseSelectable = true;
            this.reserver_btn.Click += new System.EventHandler(this.reserver_btn_Click);
            // 
            // supprimer_txt
            // 
            this.supprimer_txt.Location = new System.Drawing.Point(212, 242);
            this.supprimer_txt.Name = "supprimer_txt";
            this.supprimer_txt.Size = new System.Drawing.Size(220, 23);
            this.supprimer_txt.TabIndex = 3;
            this.supprimer_txt.Text = "Supprimer une réservation";
            this.supprimer_txt.UseSelectable = true;
            this.supprimer_txt.Click += new System.EventHandler(this.supprimer_txt_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(201, 87);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime1.TabIndex = 4;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 344);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.supprimer_txt);
            this.Controls.Add(this.reserver_btn);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.id_txt);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox id_txt;
        private MetroFramework.Controls.MetroLabel id_lbl;
        private MetroFramework.Controls.MetroButton reserver_btn;
        private MetroFramework.Controls.MetroButton supprimer_txt;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}