namespace RestoENSA
{
    partial class ModeServeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeServeur));
            this.logout_btn = new System.Windows.Forms.Button();
            this.bienvenue_lbl = new MetroFramework.Controls.MetroLabel();
            this.réserver_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(1070, 34);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(60, 57);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // bienvenue_lbl
            // 
            this.bienvenue_lbl.Location = new System.Drawing.Point(268, 41);
            this.bienvenue_lbl.Name = "bienvenue_lbl";
            this.bienvenue_lbl.Size = new System.Drawing.Size(441, 36);
            this.bienvenue_lbl.TabIndex = 3;
            // 
            // réserver_btn
            // 
            this.réserver_btn.Location = new System.Drawing.Point(191, 137);
            this.réserver_btn.Name = "réserver_btn";
            this.réserver_btn.Size = new System.Drawing.Size(152, 64);
            this.réserver_btn.TabIndex = 4;
            this.réserver_btn.Text = "Réservation";
            this.réserver_btn.UseSelectable = true;
            this.réserver_btn.Click += new System.EventHandler(this.réserver_btn_Click);
            // 
            // ModeServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 604);
            this.Controls.Add(this.réserver_btn);
            this.Controls.Add(this.bienvenue_lbl);
            this.Controls.Add(this.logout_btn);
            this.Name = "ModeServeur";
            this.Text = "Mode serveur";
            this.Load += new System.EventHandler(this.ModeServeur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private MetroFramework.Controls.MetroLabel bienvenue_lbl;
        private MetroFramework.Controls.MetroButton réserver_btn;
    }
}