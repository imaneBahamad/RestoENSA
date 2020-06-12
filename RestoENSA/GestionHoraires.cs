using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace RestoENSA
{
    public partial class GestionHoraires : MetroForm
    {
        public GestionHoraires()
        {
            InitializeComponent();
        }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new ModeAdmin("Bienvenue "+ Authentification.user_info[1] + " !").Show();
        }
    }
}
