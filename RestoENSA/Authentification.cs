using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoENSA
{
    public partial class Authentification : MetroForm
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FATIMA\Desktop\RestoENSA\RestoENSA\RestoENSA.mdf;Integrated Security=True";
        CryptographyProcessor cp = new CryptographyProcessor();
        public static object[] user_info = new object[3];
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();

                SqlCommand command = new SqlCommand("Select * from Admin", connexion);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    string salt = cp.CreateSalt(15);
                    string passwordHash = cp.GenerateHash("admin", salt);
                    SqlCommand command2 = new SqlCommand("Insert into Admin (nom_admin,login,mdp,salt) values ('Administrateur','admin','"+ passwordHash +"','" + salt + "')", connexion);
                    command2.ExecuteNonQuery();
                }
            }
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                if (qui_combo.SelectedItem.Equals("Admin"))
                {
                    SqlCommand command = new SqlCommand("Select * from Admin where login = '" + utilisateur_txt.Text + "'", connexion);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1 && cp.AreEqual(mdp_txt.Text, dt.Rows[0].Field<string>("mdp"), dt.Rows[0].Field<string>("salt")))
                    {
                        user_info[0] = dt.Rows[0].Field<int?>("id_admin");
                        user_info[1] = dt.Rows[0].Field<string>("nom_admin");
                        user_info[2] = dt.Rows[0].Field<string>("login");

                        this.Hide();
                        new ModeAdmin("Bienvenue "+ user_info[1] +" !").Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifie ton nom d'utilisateur/mot de passe");
                    }
                }
                else if (qui_combo.SelectedItem.Equals("Serveur"))
                {
                    SqlCommand command = new SqlCommand("Select * from Serveur where login = '" + utilisateur_txt.Text +  "'", connexion);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count == 1 && cp.AreEqual(mdp_txt.Text, dt.Rows[0].Field<string>("mdp"), dt.Rows[0].Field<string>("salt")))
                    {
                        user_info[0] = dt.Rows[0].Field<int?>("id_serveur");
                        user_info[1] = dt.Rows[0].Field<string>("nom_serveur");
                        user_info[2] = dt.Rows[0].Field<string>("login");

                        this.Hide();
                        new ModeServeur("Bienvenue " + user_info[1]+" !").Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifie ton nom d'utilisateur/mot de passe");
                    }

                }
            }
        }

        public static string EncodePasswordToBase64(string password)
        {
            /*byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);*/
            byte[] encData_byte = new byte[password.Length];
            encData_byte = Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;

        }

        public static string DecodePasswordFromBase64(string password)
        {
            /*byte[] data = Convert.FromBase64String(password);
            string decodedString = Encoding.Unicode.GetString(data);
            return decodedString;*/

            UTF8Encoding encoder = new UTF8Encoding();
            Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(password);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        


    }
}
