namespace RestoENSA
{
    partial class GestionServeurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionServeurs));
            this.ajouter_btn = new MetroFramework.Controls.MetroButton();
            this.retour_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajouter_btn
            // 
            this.ajouter_btn.Location = new System.Drawing.Point(874, 119);
            this.ajouter_btn.Name = "ajouter_btn";
            this.ajouter_btn.Size = new System.Drawing.Size(104, 52);
            this.ajouter_btn.TabIndex = 0;
            this.ajouter_btn.Text = "Ajouter";
            this.ajouter_btn.UseSelectable = true;
            this.ajouter_btn.Click += new System.EventHandler(this.ajouter_btn_Click);
            // 
            // retour_btn
            // 
            this.retour_btn.BackColor = System.Drawing.Color.Transparent;
            this.retour_btn.FlatAppearance.BorderSize = 0;
            this.retour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_btn.Image = ((System.Drawing.Image)(resources.GetObject("retour_btn.Image")));
            this.retour_btn.Location = new System.Drawing.Point(33, 73);
            this.retour_btn.Name = "retour_btn";
            this.retour_btn.Size = new System.Drawing.Size(53, 54);
            this.retour_btn.TabIndex = 18;
            this.retour_btn.UseVisualStyleBackColor = false;
            this.retour_btn.Click += new System.EventHandler(this.retour_btn_Click);
            // 
            // GestionServeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 565);
            this.Controls.Add(this.retour_btn);
            this.Controls.Add(this.ajouter_btn);
            this.Name = "GestionServeurs";
            this.Text = "GestionServeurs";
            this.Load += new System.EventHandler(this.GestionServeurs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ajouter_btn;
        private System.Windows.Forms.Button retour_btn;
    }
}