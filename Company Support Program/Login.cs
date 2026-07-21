using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Company_Support_Program
{
    public partial class Login : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public string getusername;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    conn.GetConnection().Open();
                    SqlCommand login = new SqlCommand("SELECT * FROM tbl_login where username=@p1 and password=@p2", conn.GetConnection());
                    login.Parameters.AddWithValue("@p1", txtUsername.Text);
                    login.Parameters.AddWithValue("@p2", txtPassword.Text);
                    SqlDataReader logindr = login.ExecuteReader();
                    if (logindr.Read())
                    {
                        getusername = txtUsername.Text;
                        MainMenu mainmenu = new MainMenu(getusername);
                        this.Hide();
                        mainmenu.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both username and password.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.GetConnection().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
