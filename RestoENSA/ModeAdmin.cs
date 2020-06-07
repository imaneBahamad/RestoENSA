using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class ModeAdmin : MetroForm
    {
        public ModeAdmin(string message)
        {
            InitializeComponent();
            bienvenue_lbl.Text = message;
        }

        private void ModeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void gestion_serveurs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestionServeurs().Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Authentification().Show();
        }
    }
}
