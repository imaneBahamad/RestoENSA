using MySql.Data.MySqlClient;
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
    public partial class Categories : MetroFramework.Forms.MetroForm
    {
        DBConnect db;


        public Categories()
        {
            InitializeComponent();
            db = new DBConnect();
            db.Afficher_Categorie(Categorie_grid);
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

        private void ajouter_categorie_button(object sender, EventArgs e)
        {
            bool verify1;
            try
            {
                int id = 0;
                string nom = "";
                verify1 = int.TryParse(categorie_code_box.Text, out id); if (!verify1) { throw new Ex("le code doit etre un nombre entier ! "); }
                if (string.IsNullOrWhiteSpace(categorie_nom_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = categorie_nom_box.Text; }

                if (db.check_Existence("Categorie", id.ToString()))
                {
                    MessageBox.Show("la categorie du code " + id + " existe deja !");
                }
                else
                {
                    
                    db.Ajouter_Categorie(id, nom);
                    MessageBox.Show("Succes!");
                    ClearTextBoxes();
                    db.Afficher_Categorie(Categorie_grid);


                }

            }
            catch (Exception ex)
            {

            }

        }


        private void modifier_categorie_button(object sender, EventArgs e)
        {
            bool verify1;
            try
            {
                int id = 0;
                string nom = "";
                verify1 = int.TryParse(categorie_code_box.Text, out id); if (!verify1) { throw new Ex("le code doit etre un nombre entier ! "); }
                if (string.IsNullOrWhiteSpace(categorie_nom_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = categorie_nom_box.Text; }

                if (!db.check_Existence("Categorie", id.ToString()))
                {
                    MessageBox.Show("la categorie du code " + id + " n'existe pas pour le modifier !");
                }
                else
                {
                    db.Modifier_Categorie(id, nom);
                    MessageBox.Show("Succes!");
                    ClearTextBoxes();
                    db.Afficher_Categorie(Categorie_grid);

                }

            }
            catch (Exception ex)
            {

            }

        }

        private void supprimer_categorie_button(object sender, EventArgs e)
        {
            try
            {
                string id = categorie_code_box.Text;

                //verifier si le text box est non vide || verifier si le code existe
                if (!db.check_Existence("Categorie", id) || string.IsNullOrWhiteSpace(id)) { throw new Ex("vous devez remplir le champ id!"); }


                //verifier si la categorie ne contient aucun plat
                int verify = db.Verify_Empty_Categorie(id);

                if (verify != 0) { throw new Ex("la categorie que vous voulez supprimer contient des plats!"); }
                else
                {
                    int code = int.Parse(id);
                    MessageBox.Show("Succes!");
                    db.Supprimer_Categorie(code);
                    ClearTextBoxes();
                    db.Afficher_Categorie(Categorie_grid);
                }


            }
            catch (Exception ex)
            {

            }


        }

        private void Categorie_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Categorie_grid.Rows[e.RowIndex];

                categorie_code_box.Text = row.Cells["id_categorie"].Value.ToString();
                categorie_nom_box.Text = row.Cells["nom_categorie"].Value.ToString();


            }
        }
    }
}
