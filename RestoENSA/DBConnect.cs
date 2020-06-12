using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    class DBConnect
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;
        public DataSet ds;

        public DBConnect()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True");
            if(conn.State != ConnectionState.Open )
            {
                conn.Open();
            }
        }

        public void Afficher_Plat(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_plat,id_categorie,nom_plat,prix,disponible FROM Plat", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);

            ds.Tables[0].Columns.Add("Disponibilité", typeof(string));

            grid.DataSource = ds.Tables[0];

            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[4].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[5].Value = "disponible";
                }
                if (grid.Rows[i].Cells[4].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[5].Value = "non disponible";
                }

            }



            grid.Columns["id_plat"].Visible = false;
            grid.Columns["id_categorie"].Visible = false;
            grid.Columns["disponible"].Visible = false;


        }

        public void Afficher_Plat_ParFiltre(MetroFramework.Controls.MetroGrid grid, string nom_categorie)
        {
            int code = Categorie_Nom_Code(nom_categorie);
            cmd = new SqlCommand("SELECT id_plat,id_categorie,nom_plat,prix,disponible FROM Plat where id_categorie = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("Disponibilité", typeof(string));

            grid.DataSource = ds.Tables[0];

            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[4].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[5].Value = "disponible";
                }
                if (grid.Rows[i].Cells[4].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[5].Value = "non disponible";
                }

            }



            grid.Columns["id_plat"].Visible = false;
            grid.Columns["id_categorie"].Visible = false;
            grid.Columns["disponible"].Visible = false;
            cmd.Parameters.Clear();

        }
        //categorie_nom_code return the id of the categorie's name given in input
        public int Categorie_Nom_Code(string nom)
        {

            cmd = new SqlCommand("SELECT id_categorie FROM Categorie where nom_categorie=@nom", conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return id;


        }

        //categorie_code_nom return the nom of the categorie's id given in input
        public string Categorie_Code_Nom(int id)
        {

            cmd = new SqlCommand("SELECT nom_categorie FROM Categorie where id_categorie=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return ds.Tables[0].Rows[0][0].ToString();


        }

        public void Fill_Categorie(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom_categorie FROM Categorie", conn);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        public void Fill_Disponible(MetroFramework.Controls.MetroComboBox combo)
        {

            combo.Items.Clear();
            combo.ResetText();
            combo.Items.Add("disponible");
            combo.Items.Add("non disponible");
            combo.SelectedItem = "disponible";



        }

        public void Ajouter_Plat(int id_plat, string nom_plat, float prix, int var_disponible, string categorie)
        {
            int code_categorie = Categorie_Nom_Code(categorie);
            cmd = new SqlCommand("insert into Plat (id_plat,nom_plat,prix,disponible,id_categorie) values (@id,@nom,@prix,@dispo,@categorie) ",conn);
            cmd.Parameters.AddWithValue("@id", id_plat);
            cmd.Parameters.AddWithValue("@nom", nom_plat);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@dispo", var_disponible);
            cmd.Parameters.AddWithValue("@categorie", code_categorie);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();     
        }

        public void Modifier_Plat(int id_plat, string nom_plat, float prix,int var_disponible, string categorie)
        {
            int code_categorie = Categorie_Nom_Code(categorie);
            cmd = new SqlCommand("update Plat set nom_plat=@nom,prix=@prix, disponible=@dispo,id_categorie=@categorie where id_plat=@id ",conn);
            cmd.Parameters.AddWithValue("@nom", nom_plat);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@dispo", var_disponible);
            cmd.Parameters.AddWithValue("@categorie", code_categorie);
            cmd.Parameters.AddWithValue("@id", id_plat);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Supprimer_Plat(int code)
        {
            cmd = new SqlCommand("delete from Plat where id_plat = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        

        public bool check_Existence(string table, string code)
        {
            if (table.Equals("Plat"))
            {
                cmd = new SqlCommand("select id_plat from Plat", conn);
            }
            if (table.Equals("Tablee"))
            {
                cmd = new SqlCommand("select id_table from Tablee", conn);
            }
            if (table.Equals("Categorie"))
            {
                cmd = new SqlCommand("select id_categorie from Categorie", conn);
            }



            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                if (x[0].ToString() == code) { return true; }

            }
            return false;

        }


        //***********************************************************
        //Categorie

        public void Afficher_Categorie(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_categorie,nom_categorie FROM Categorie", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];

        }

        public void Ajouter_Categorie(int id,string nom)
        {
            cmd = new SqlCommand("insert into Categorie (id_categorie,nom_categorie) values (@id,@nom)",conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Modifier_Categorie(int id, string nom)
        {
            cmd = new SqlCommand("update Categorie set nom_categorie=@nom where id_categorie=@id ",conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Supprimer_Categorie(int id)
        {
            cmd = new SqlCommand("delete from Categorie where id_categorie = @id",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


        public int Verify_Empty_Categorie(string id)
        {
            cmd = new SqlCommand("SELECT id_categorie FROM Plat where id_categorie = @code", conn);
            cmd.Parameters.AddWithValue("@code", id);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return ds.Tables[0].Rows.Count;
        }



        //*******************************************************************
        //Tables
        public void Afficher_Table(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT id_table,reservee FROM Tablee", conn);

            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);

            ds.Tables[0].Columns.Add("Reservation", typeof(string));            

            grid.DataSource = ds.Tables[0];
            grid.Columns["reservee"].Visible = false;
            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                if (grid.Rows[i].Cells[1].Value.ToString() == "True")
                {
                    grid.Rows[i].Cells[2].Value = "reservée";
                }
                if (grid.Rows[i].Cells[1].Value.ToString() == "False")
                {
                    grid.Rows[i].Cells[2].Value = "non reservée";
                }

            }
        }

        public void Ajouter_Table(int id)
        {
            cmd = new SqlCommand("insert into Tablee (id_table) values (@id)",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public bool Verify_Reserved_Table(int id)
        {
            cmd = new SqlCommand("SELECT reservee FROM Tablee where id_table = @code", conn);
            cmd.Parameters.AddWithValue("@code", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            return bool.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public void Supprimer_Table(int id)
        {
            cmd = new SqlCommand("delete from Tablee where id_table = @id",conn);
            cmd.Parameters.AddWithValue("@id", id);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


    }
}
