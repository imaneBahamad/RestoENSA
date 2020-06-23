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
    public partial class Calendrier : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FATIMA\Desktop\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";

        public Calendrier()
        {
            InitializeComponent();
        }

        //private void retour_btn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    new ModeAdmin("Bienvenue " + Authentification.user_info[1] + " !").Show();
        //}

        public void disp_data1()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command = new SqlCommand("select numero_semaine,nom_serveur,horaire_shift1,horaire_shift2,debut_semaine,fin_semaine from Serveur s,Calendrier c WHERE s.id_calendrier=c.id_calendrier ", connexion);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                Calendrier_se_grid.DataSource = dt;
            }
        }

        public void disp_data2()
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                SqlCommand command2 = new SqlCommand("select numero_semaine,nom_chef,horaire_shift1,horaire_shift2,debut_semaine,fin_semaine from Chef ch,Calendrier c WHERE ch.id_calendrier=c.id_calendrier ", connexion);
                command2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(command2);
                da2.Fill(dt2);
                Calendrier_che_grid.DataSource = dt2;
            }
        }



        private void afficher_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (calend_combo.SelectedIndex == -1 )
                {
                    throw new Ex("Veuillez remplir le champ vide !!");
                }
                if (calend_combo.SelectedItem.Equals("Serveurs"))
                {
                    Calendrier_che_grid.Hide();
                    Calendrier_se_grid.Show();
                    disp_data1();
                }
                else if (calend_combo.SelectedItem.Equals("Chefs"))
                {
                    Calendrier_se_grid.Hide();
                    Calendrier_che_grid.Show();
                    disp_data2();
                }
                else
                {

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
