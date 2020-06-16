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
    public partial class GestionChefs : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        
        public GestionChefs()
        {
            InitializeComponent();
        }

        private void GestionChefs_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "")
                MessageBox.Show("veuillez remplire le champ vide !!!!!");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("Insert into Chef (nom_chef) values ('" + nom_txt.Text + "')", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Chef bien ajouté !", "Succès");
                    disp_data();
                }
                vider_btn_Click(sender, e);
            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            nom_txt.Text = "";
        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select id_chef as code_chef,nom_chef from chef", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                chef_grid.DataSource = dt;
            }
        }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new ModeAdmin("Bienvenue " + Authentification.user_info[1] + " !").Show();
        }

        private void modif_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" )
            {
                MessageBox.Show("Veuillez selectionner un chef !!!!!");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE  Chef SET nom_chef = @nom   WHERE id_chef = @id", connexion);
                    command.Parameters.AddWithValue("@nom", nom_txt.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Succés de la MODIFICATION !!!!!");
                    disp_data();
                }
                vider_btn_Click(sender, e);
            }
        }



        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un chef !!!!!");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Chef WHERE id_chef = '" + id_txt.Text + "'", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Succés de la SUPPRESSION !!!!!");
                    disp_data();

                }
                vider_btn_Click(sender, e);
            }
        }

        private void chef_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chef_grid.CurrentRow.Selected = true;
            nom_txt.Text = chef_grid.Rows[e.RowIndex].Cells["nom_chef"].FormattedValue.ToString();
            id_txt.Text = chef_grid.Rows[e.RowIndex].Cells["code_chef"].FormattedValue.ToString();
        }
    }
}
