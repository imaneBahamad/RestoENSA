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
    public partial class GestionServeurs : MetroForm
    {
        public GestionServeurs()
        {
            InitializeComponent();
        }

        private void GestionServeurs_Load(object sender, EventArgs e)
        {

        }

        private void ajouter_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AjouterServeur().Show();
        }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new ModeAdmin("Bienvenue " + Authentification.user_info[1] + " !").Show();
        }
    }
}
