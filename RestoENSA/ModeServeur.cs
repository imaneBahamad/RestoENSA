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
    public partial class ModeServeur : MetroForm
    {
        public ModeServeur(string message)
        {
            InitializeComponent();
            bienvenue_lbl.Text = message;
        }

        private void ModeServeur_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Authentification().Show();
        }
    }
}
