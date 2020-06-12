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
    public partial class GestionServeur : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FATIMA\Desktop\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        CryptographyProcessor cp = new CryptographyProcessor();

        public GestionServeur()
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
                    disp_data();
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
            new ModeAdmin("Bienvenue Administrateur !").Show();
        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select nom_serveur,login from serveur", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                serveur_grid.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modif_btn_Click(object sender, EventArgs e)
        {

        }

        private void serveur_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serveur_grid.CurrentRow.Selected = true;
            nom_txt.Text = serveur_grid.Rows[e.RowIndex].Cells["nom_serveur"].FormattedValue.ToString();
            login_txt.Text = serveur_grid.Rows[e.RowIndex].Cells["login"].FormattedValue.ToString();


        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" || login_txt.Text == "")
            {
                MessageBox.Show("veuillez selectionner un serveur !!!!!");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Serveur WHERE nom_serveur = '" + nom_txt.Text + "'", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Succés du SUPPRESSION !!!!!");
                    disp_data();

                }
                vider_btn_Click(sender, e);
            }


        }
    }
}
