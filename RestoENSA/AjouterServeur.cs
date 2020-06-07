using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class AjouterServeur : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        CryptographyProcessor cp = new CryptographyProcessor();

        public AjouterServeur()
        {
            InitializeComponent();
        }

        private void AjouterServeur_Load(object sender, EventArgs e)
        {

        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                if (mdp_txt.Text.Equals(confirmer_mdb_txt.Text))
                {
                    string salt = cp.CreateSalt(15);
                    string passwordHash = cp.GenerateHash(mdp_txt.Text, salt);
                    SqlCommand command = new SqlCommand("Insert into Serveur (nom_serveur,login,mdp,salt) values ('" +
                        nom_txt.Text + "','" + login_txt.Text + "','" + passwordHash + "','" + salt + "')", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Serveur bien ajouté !", "Succès");
                }
                else
                {
                    MessageBox.Show("Le mot de passe ne matche pas sa confirmation !","Erreur");
                }
            }
            vider_btn_Click(sender, e);
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            nom_txt.Text = "";
            login_txt.Text = "";
            mdp_txt.Text = "";
            confirmer_mdb_txt.Text = "";
        }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new GestionServeurs().Show();
        }
    }
}
