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
    public partial class Plats : MetroFramework.Forms.MetroForm
    {
        DBConnect db;

        public Plats()
        {
            InitializeComponent();
            db = new DBConnect();
            db.Fill_Categorie(categorie_box);
            db.Fill_Categorie(filtre_combobox);
            db.Afficher_Plat(plat_grid);
            db.Fill_Disponible(disponible_combo);
        }

        //dbConnect


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

        private void ajouter_plat_button(object sender, EventArgs e)
        {
            bool verify1;
            bool verify2;
            try
            {
                int codePlat = 0;
                string nom = "";
                float prix = 0;
                string categorie = "";
                int var_disponible = 1;


                verify1 = int.TryParse(code_plat_box.Text, out codePlat); if (!verify1) { throw new Ex("le code doit etre un nombre entier ! "); }
                if (string.IsNullOrWhiteSpace(nom_plat_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = nom_plat_box.Text; }
                verify2 = float.TryParse(prix_plat_box.Text, out prix); if (!verify2) { throw new Ex("le prix doit etre un nombre reel ! "); }
                if (categorie_box.SelectedIndex == -1) { throw new Ex("vous devez remplir le champ categorie !!"); } else { categorie = categorie_box.SelectedItem.ToString(); }

                // si l'admin coche la case non-disponible c'est bon, sinon la disponibilte du plat est tjrs true
                if (disponible_combo.Text == "non disponible")
                {
                    var_disponible = 0;
                }


                if (db.check_Existence("Plat", codePlat.ToString()))
                {
                    MessageBox.Show("le plat du code " + codePlat + " existe deja !\n" +
                        "Pour appliquer une modificaton cliquez sur Modifier");
                }
                else
                {

                    db.Ajouter_Plat(codePlat, nom, prix,var_disponible, categorie);
                    MessageBox.Show("succes!!");

                    ClearTextBoxes();
                    db.Fill_Categorie(categorie_box);
                    db.Afficher_Plat(plat_grid);
                    db.Fill_Disponible(disponible_combo);

                }
            }
            catch (Exception ex)

            {

            }

        }

        private void modifier_plat_button(object sender, EventArgs e)
        {
            bool verify1;
            bool verify2;
            try
            {
                int codePlat = 0;
                float prix = 0;
                string nom = "";
                string categorie = "";
                int var_disponible = 1;

                verify1 = int.TryParse(code_plat_box.Text, out codePlat); if (!verify1) { throw new Ex("le code doit etre un nombre entier ! "); }
                if (string.IsNullOrWhiteSpace(nom_plat_box.Text)) { throw new Ex("vous devez remplir le champ nom!!"); } else { nom = nom_plat_box.Text; }
                verify2 = float.TryParse(prix_plat_box.Text, out prix); if (!verify2) { throw new Ex("le prix doit etre un nombre reel ! "); }
                if (categorie_box.SelectedIndex == -1) { throw new Ex("vous devez remplir le champ categorie !!"); } else { categorie = categorie_box.SelectedItem.ToString(); }

                // si l'admin coche la case non-disponible c'est bon, sinon la disponibilte du plat est tjrs true
                if (disponible_combo.Text == "non disponible")
                {
                    var_disponible = 0;
                }


                if (!db.check_Existence("Plat", codePlat.ToString()))
                {
                    MessageBox.Show("le plat du code " + codePlat + " existe deja !\n" +
                        "Pour appliquer une modificaton cliquez sur Modifier");
                }
                else
                {
                    db.Modifier_Plat(codePlat, nom, prix, var_disponible, categorie);
                    MessageBox.Show("succes!!");

                    ClearTextBoxes();
                    db.Afficher_Plat(plat_grid);
                    db.Fill_Disponible(disponible_combo);


                }//fin else
            }//fin try
            catch (Exception ex)

            {

            }
        }//fin fct

        private void supprimer_button(object sender, EventArgs e)
        {
            string code = code_plat_box.Text;
            if (!db.check_Existence("Plat", code))
            {
                MessageBox.Show("le plat du code " + code + " n'existe pas !\n");
            }
            else
            {
                int id = int.Parse(code);
                db.Supprimer_Plat(id);
                db.Afficher_Plat(plat_grid);
                db.Fill_Disponible(disponible_combo);
                ClearTextBoxes();
                MessageBox.Show("succes!!");

            }
        }

        private void Quitter_button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filtre_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_categorie = filtre_combobox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(nom_categorie))
            {
                db.Afficher_Plat(plat_grid);
            }
            else
            {
                db.Afficher_Plat_ParFiltre(plat_grid, nom_categorie);
            }
        }

        private void plat_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categorie_box.SelectedItem = "";
                DataGridViewRow row = this.plat_grid.Rows[e.RowIndex];

                nom_plat_box.Text = row.Cells["nom_plat"].Value.ToString();
                prix_plat_box.Text = row.Cells["prix"].Value.ToString();
                code_plat_box.Text = row.Cells["id_plat"].Value.ToString();
                disponible_combo.SelectedItem = row.Cells["Disponibilité"].Value.ToString(); ;

                int codeCat = int.Parse(row.Cells["id_categorie"].Value.ToString());
                categorie_box.SelectedItem = db.Categorie_Code_Nom(codeCat);//remember that 'Categorie_Code_Nom' return the name of the categorie's code given in input

            }
        }
    }
}
