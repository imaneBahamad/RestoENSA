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
    public partial class Reservation : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void reserver_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
                MessageBox.Show("Veuillez remplire le champ !!!!!");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();

                    SqlCommand command = new SqlCommand("Select * from Tablee where id_table = @id", connexion);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1 && dt.Rows[0].Field<bool>("reservee")==false)
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE Tablee SET reservee = 1 WHERE id_table = @id", connexion);
                        command2.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Table réservée avec succès !!", "Succès");
                    }
                    else
                    {
                        MessageBox.Show("Table introuvable ou déjà réservée !!", "Erreur");
                    }
                }
            }
        }

        private void supprimer_txt_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
                MessageBox.Show("Veuillez remplire le champ !!!!!");
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();

                    SqlCommand command = new SqlCommand("Select * from Tablee where id_table = @id", connexion);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1 && dt.Rows[0].Field<bool>("reservee") == true)
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE Tablee SET reservee = 0 WHERE id_table = @id", connexion);
                        SqlCommand command3 = new SqlCommand("DELETE FROM Commande WHERE id_table = @id", connexion);

                        command2.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));
                        command3.Parameters.AddWithValue("@id", Convert.ToInt32(id_txt.Text));

                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();

                        MessageBox.Show("Réservation supprimée avec succès !!", "Succès");
                    }
                    else
                    {
                        MessageBox.Show("Table introuvable ou n'est pas réservée !!", "Erreur");
                    }
                }
            }
        }
    }
}
