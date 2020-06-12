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
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FATIMA\Desktop\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        CryptographyProcessor cp = new CryptographyProcessor();
        public GestionChefs()
        {
            InitializeComponent();
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
                    SqlCommand command = new SqlCommand("Insert into Chef  values ('" + nom_txt.Text + "')", connexion);
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
            new ModeAdmin("Bienvenue Administrateur !").Show();
        }

        private void chef_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chef_grid.CurrentRow.Selected = true;
            nom_txt.Text = chef_grid.Rows[e.RowIndex].Cells["nom_chef"].FormattedValue.ToString();
        }

        private void modif_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" )
            {
                MessageBox.Show("veuillez selectionner un chef !!!!!");
            }
            else
            {
                //using (SqlConnection connexion = new SqlConnection(connectionString))
                //{
                //    connexion.Open();
                //    SqlCommand command = new SqlCommand("UPDATE  Chef SET nom_chef = '" + nom_txt.Text + "'   WHERE id_chef = (SELECT id_chef from chef where nom_chef = '" + nom_txt.Text + "')", connexion);
                //    command.ExecuteNonQuery();
                //    MessageBox.Show("Succés du MODIFICATION !!!!!");
                //    disp_data();

                //}
                vider_btn_Click(sender, e);
            }
        }



        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "")
            {
                MessageBox.Show("veuillez selectionner un chef !!!!!");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Chef WHERE nom_chef = '" + nom_txt.Text + "'", connexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Succés du SUPPRESSION !!!!!");
                    disp_data();

                }
                vider_btn_Click(sender, e);
            }
        }
    }
}
