using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Commande : MetroFramework.Forms.MetroForm
    {
        DBConnect db;
        public Commande()
        {

            InitializeComponent();
            db = new DBConnect();
            if (db.conn.State != ConnectionState.Open)
            {
                db.conn.Open();
            }
            db.Fill_Categorie(categorie_box);
            db.Fill_Table(filtre_combobox);
            db.Fill_Table(id_table_box);
            db.Afficher_Plat(plat_grid);
            db.Afficher_Cmd(Commande_grid);
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

        private void Confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                string nom_plat = nom_plat_box.Text;
                float prix = 0;
                int id_table = 0;

                if (string.IsNullOrWhiteSpace(prix_plat_box.Text)) { throw new Ex("vous devez selectionner un plat !!"); } else { prix = float.Parse(prix_plat_box.Text); }
                if (id_table_box.SelectedIndex == -1 || string.IsNullOrWhiteSpace(id_table_box.SelectedItem.ToString())) { throw new Ex("vous devez remplir le champ table !!"); } else { id_table = int.Parse(id_table_box.SelectedItem.ToString()); }

                if (db.check_Existence("Commande", code_cmd_box.Text))
                {
                    MessageBox.Show("la Commande du code " + code_cmd_box.Text + " existe deja \n pour la modifier cliquer sur Modifier !");
                }
                else
                {
                    db.Ajouter_Cmd(prix, nom_plat, id_table);
                    MessageBox.Show("succes!!");


                    ClearTextBoxes();
                    db.Afficher_Cmd(Commande_grid);
                    db.Afficher_Plat(plat_grid);

                }
                
            }
            catch (Exception ex)

            {

            }
        }

        private void Modifier_Cmd_Click(object sender, EventArgs e)
        {
            try
            {
                int cmd_Code = 0;
                string nom_plat = nom_plat_box.Text;
                float prix = 0;
                int id_table = 0;

                if (string.IsNullOrWhiteSpace(code_cmd_box.Text)) { throw new Ex("vous devez selectionner la commande \n que vous voulez modifier !!"); } else { cmd_Code = int.Parse(code_cmd_box.Text); }
                if (string.IsNullOrWhiteSpace(prix_plat_box.Text)) { throw new Ex("vous devez selectionner un plat !!"); } else { prix = float.Parse(prix_plat_box.Text); }
                if (id_table_box.SelectedIndex == -1|| string.IsNullOrWhiteSpace(id_table_box.SelectedItem.ToString()) ) { throw new Ex("vous devez remplir le champ table !!"); } else { id_table = int.Parse(id_table_box.SelectedItem.ToString()); }


                
                db.Modifier_Cmd(cmd_Code, nom_plat,prix, id_table);
                MessageBox.Show("succes!!");


                ClearTextBoxes();
                db.Afficher_Cmd(Commande_grid);
                db.Afficher_Plat(plat_grid);


                
            }
            catch (Exception ex)

            {

            }
        }

        private void categorie_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_categorie = categorie_box.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(nom_categorie))
            {
                db.Afficher_Plat(plat_grid);
            }
            else
            {
                db.Afficher_Plat_ParFiltre(plat_grid, nom_categorie);
            }
        }

        private void filtre_cmd_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_table = filtre_combobox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(id_table))
            {
                db.Afficher_Cmd(Commande_grid);
            }
            else
            {
                int table = int.Parse(id_table);
                db.Afficher_Cmd_ParFiltre(Commande_grid, table);
            }
        }

        private void Commande_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_table_box.SelectedItem = "";
                DataGridViewRow row = this.Commande_grid.Rows[e.RowIndex];
                code_cmd_box.Text = row.Cells["id_commande"].Value.ToString();
                nom_plat_box.Text = row.Cells["nom_plat"].Value.ToString();
                prix_plat_box.Text = row.Cells["facture"].Value.ToString();
                int codeTable = int.Parse(row.Cells["id_table"].Value.ToString());
                id_table_box.SelectedItem = codeTable.ToString();

            }
        }

        private void plat_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.plat_grid.Rows[e.RowIndex];
                string dispoVerify = row.Cells["Disponibilité"].Value.ToString();
                try
                {
                    if (dispoVerify == "non disponible") { ClearTextBoxes(); throw new Ex("Ce plat est non disponible pour le moment !"); }
                    nom_plat_box.Text = row.Cells["nom_plat"].Value.ToString();
                    prix_plat_box.Text = row.Cells["prix"].Value.ToString();

                }
                catch (Exception ex)
                {

                }
            }
        }


        private void Vider_Champs(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Supprimer_Cmd_Button(object sender, EventArgs e)
        {
            string code = code_cmd_box.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Vous devez selectionner une commande d'abord!");
            }
            else
            {

                if (MessageBox.Show("Voulez vous vraiment supprimer cette Commande ?", "Supprimer Commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    int id = int.Parse(code);
                    db.Supprimer_Cmd(id);
                    db.Afficher_Cmd(Commande_grid);
                    ClearTextBoxes();

                }

                else
                {
                    MessageBox.Show("Commande non Supprimée !", "Spprimer Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
