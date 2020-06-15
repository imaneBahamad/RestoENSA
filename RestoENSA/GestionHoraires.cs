﻿using System;
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
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FATIMA\Desktop\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        DBConnect db;
        public GestionHoraires()
        {
            InitializeComponent();
            db = new DBConnect();
            chefComboBox();
            serveurComboBox();
        }

        private void retour_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new ModeAdmin("Bienvenue " + Authentification.user_info[1] + " !").Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("veuillez remplire le(s) champ(s) vide !!!!!");

            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("Insert into Calendrier (horaire_shift1,horaire_shift2,debut_semaine,fin_semaine)  values (@shift1,@shift2,@debut,@fin)", connexion);
                    command.Parameters.AddWithValue("@shift1", shift1_comboBox.Text);
                    command.Parameters.AddWithValue("@shift2", shift2_comboBox.Text);
                    command.Parameters.AddWithValue("@debut", SqlDbType.Date).Value = debut_time.Value;
                    command.Parameters.AddWithValue("@fin", SqlDbType.Date).Value = fin_time.Value;
                    command.Parameters.AddWithValue("@num", numero_txt.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Calendrier bien ajouté !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
                ClearTextBoxes();
            }

        }

        public void disp_data()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select numero_semaine,debut_semaine,fin_semaine,horaire_shift1,horaire_shift2,nom_serveur,nom_chef from Calendrier", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                Horaire_grid.DataSource = dt;
            }
        }

        private void vider_btn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MetroFramework.Controls.MetroTextBox || control is MetroFramework.Controls.MetroComboBox)
                    {
                        control.ResetText();
                    }

                    else
                        func(control.Controls);

            };

            func(Controls);
        }

        private void modif_btn_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("veuillez selectionner une calendrier !!!!!");

            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Calendrier SET horaire_shift1=@shift1, horaire_shift2=@shift2, debut_semaine=@debut, fin_semaine=@fin WHERE numero_semaine=@num", connexion);
                    command.Parameters.AddWithValue("@shift1", shift1_comboBox.Text);
                    command.Parameters.AddWithValue("@shift2", shift2_comboBox.Text);
                    command.Parameters.AddWithValue("@debut", SqlDbType.Date).Value = debut_time.Value;
                    command.Parameters.AddWithValue("@fin", SqlDbType.Date).Value = fin_time.Value;
                    command.Parameters.AddWithValue("@num", numero_txt.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Succés de la MODIFICATION !!!!!");
                    disp_data();
                }
                ClearTextBoxes();
            }
        }

        private void Horaire_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Horaire_grid.CurrentRow.Selected = true;
            numero_txt.Text = Horaire_grid.Rows[e.RowIndex].Cells["numero_semaine"].FormattedValue.ToString();
            debut_time.Text = Horaire_grid.Rows[e.RowIndex].Cells["debut_semaine"].FormattedValue.ToString();
            fin_time.Text = Horaire_grid.Rows[e.RowIndex].Cells["fin_semaine"].FormattedValue.ToString();
            shift1_comboBox.Text = Horaire_grid.Rows[e.RowIndex].Cells["horaire_shift1"].FormattedValue.ToString();
            shift2_comboBox.Text = Horaire_grid.Rows[e.RowIndex].Cells["horaire_shift2"].FormattedValue.ToString();

        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "")
            {
                MessageBox.Show("veuillez selectionner une calendrier !!!!!");

            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Calendrier WHERE numero_semaine=@num", connexion);
                    command.Parameters.AddWithValue("@num", numero_txt.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Succés de la SUPPRESSION !!!!!");
                    disp_data();
                }
                ClearTextBoxes();
            }
        }

        private void show_chef_btn_Click(object sender, EventArgs e)
        {
            disp_data();
            nomChef_label.Show();
            chef_comboBox.Show();
            affecter_chef_btn.Show();
        }

        private void show_serveur_btn_Click(object sender, EventArgs e)
        {
            disp_data();
            nomServeur_label.Show();
            serveur_comboBox.Show();
            affecter_serveur_btn.Show();
        }

        private void chef_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void chefComboBox()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select nom_chef from Chef ;", connexion);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    chef_comboBox.Items.Add(myReader["nom_chef"].ToString());
                }
            }
        }

        void serveurComboBox()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select nom_serveur from Serveur ;", connexion);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    serveur_comboBox.Items.Add(myReader["nom_serveur"].ToString());
                }
            }
        }

        private void affecter_chef_btn_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "" || chef_comboBox.Text == "")
            { MessageBox.Show("Veuillez selectionner un calendrier et un chef !!!!"); }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Calendrier SET nom_chef=@chef WHERE numero_semaine=@num", connexion);
                    command.Parameters.AddWithValue("@chef", chef_comboBox.Text);
                    command.Parameters.AddWithValue("@num", numero_txt.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Le Chef est affecter au calendrie !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
            }

        }

        private void affecter_serveur_btn_Click(object sender, EventArgs e)
        {
            if (debut_time.Text == "" || fin_time.Text == "" || shift1_comboBox.Text == "" || shift2_comboBox.Text == "" || serveur_comboBox.Text == "")
            { MessageBox.Show("Veuillez selectionner un calendrier et un chef !!!!"); }
            else
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    SqlCommand command = new SqlCommand("UPDATE Calendrier SET nom_serveur=@serveur WHERE numero_semaine=@num", connexion);
                    command.Parameters.AddWithValue("@serveur", serveur_comboBox.Text);
                    command.Parameters.AddWithValue("@num", numero_txt.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Le serveur est affecter au calendrie !", "Succès");
                    command.Parameters.Clear();
                    disp_data();
                }
            }
        }
    }

}
