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
            this.id_lbl = new MetroFramework.Controls.MetroLabel();
            this.reserver_btn = new MetroFramework.Controls.MetroButton();
            this.supprimer_txt = new MetroFramework.Controls.MetroButton();
            this.reservation_box = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(100, 146);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(129, 20);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "Numéro de la table";
            // 
            // reserver_btn
            // 
            this.reserver_btn.Location = new System.Drawing.Point(93, 242);
            this.reserver_btn.Name = "reserver_btn";
            this.reserver_btn.Size = new System.Drawing.Size(103, 23);
            this.reserver_btn.TabIndex = 2;
            this.reserver_btn.Text = "Réserver";
            this.reserver_btn.UseSelectable = true;
            this.reserver_btn.Click += new System.EventHandler(this.reserver_btn_Click);
            // 
            // supprimer_txt
            // 
            this.supprimer_txt.Location = new System.Drawing.Point(214, 242);
            this.supprimer_txt.Name = "supprimer_txt";
            this.supprimer_txt.Size = new System.Drawing.Size(220, 23);
            this.supprimer_txt.TabIndex = 3;
            this.supprimer_txt.Text = "Supprimer une réservation";
            this.supprimer_txt.UseSelectable = true;
            this.supprimer_txt.Click += new System.EventHandler(this.supprimer_txt_Click);
            // 
            // reservation_box
            // 
            this.reservation_box.FormattingEnabled = true;
            this.reservation_box.ItemHeight = 24;
            this.reservation_box.Location = new System.Drawing.Point(259, 146);
            this.reservation_box.Name = "reservation_box";
            this.reservation_box.Size = new System.Drawing.Size(170, 30);
            this.reservation_box.TabIndex = 4;
            this.reservation_box.UseSelectable = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 344);
            this.Controls.Add(this.reservation_box);
            this.Controls.Add(this.supprimer_txt);
            this.Controls.Add(this.reserver_btn);
            this.Controls.Add(this.id_lbl);
            this.Name = "Reservation";
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel id_lbl;
        private MetroFramework.Controls.MetroButton reserver_btn;
        private MetroFramework.Controls.MetroButton supprimer_txt;
        private MetroFramework.Controls.MetroComboBox reservation_box;
    }
}