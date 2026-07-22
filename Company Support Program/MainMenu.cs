using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Company_Support_Program
{
    public partial class MainMenu : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public MainMenu()
        {
            InitializeComponent();
        }
        private object id;

        private void Refreshtable()
        {
            this.tbl_CompanyTableAdapter.Fill(this.companySupportDataSet1.tbl_Company);

        }

        private void list()
        {
            try
            {

                cmbBoxCompanyName.Items.Clear();
                connection.GetConnection().Open();
                SqlCommand companyname = new SqlCommand("SELECT DISTINCT companyname FROM tbl_Company ", connection.GetConnection());
                SqlDataReader companynamedr = companyname.ExecuteReader();
                while (companynamedr.Read())
                {
                    cmbBoxCompanyName.Items.Add(companynamedr[0].ToString());
                }
                connection.GetConnection().Close();
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
                connection.GetConnection().Close();
            }
        }

        private void clean()
        {
            cmbBoxCompanyName.Text = "";
            txtExplanation.Text = "";
            chkBoxResult.Checked = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Refreshtable();
            btnUpdate.Enabled = false;
            list();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(cmbBoxCompanyName.Text) && !string.IsNullOrWhiteSpace(txtExplanation.Text))
                {
                    
                    connection.GetConnection().Open();
                    SqlCommand newcompany = new SqlCommand("INSERT INTO tbl_Company (companyname, explanation, result, date,username) " +
                        "VALUES (@p1, @p2, @p3, @p4, @p5) ", connection.GetConnection());
                    newcompany.Parameters.AddWithValue("@p1", cmbBoxCompanyName.Text);
                    newcompany.Parameters.AddWithValue("@p2", txtExplanation.Text);
                    if (chkBoxResult.Checked) { newcompany.Parameters.AddWithValue("@p3", true); }
                    else { newcompany.Parameters.AddWithValue("@p3", false); }
                    newcompany.Parameters.Add("@p4", SqlDbType.Date).Value = DateTime.Now;
                    newcompany.Parameters.AddWithValue("@p5", getusername);
                    newcompany.ExecuteNonQuery();
                    connection.GetConnection().Close();
                    list();
                    Refreshtable();
                    clean();
                   
                }
                else
                {
                    MessageBox.Show("Please Fields All Lines");
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
                connection.GetConnection().Close();
            }
        }
        private string getusername;
        public MainMenu(string user)
        {
            InitializeComponent();
            getusername = user;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            try
            {
                bool truefalse;
                int election = dataGridView1.SelectedCells[0].RowIndex;
                id = dataGridView1.Rows[election].Cells[0].Value.ToString();
                cmbBoxCompanyName.Text = dataGridView1.Rows[election].Cells[1].Value.ToString();
                txtExplanation.Text = dataGridView1.Rows[election].Cells[2].Value.ToString();
                truefalse = Convert.ToBoolean(dataGridView1.Rows[election].Cells[3].Value);

                if (truefalse == true) { chkBoxResult.Checked = true; }
                else { chkBoxResult.Checked = false; }

            }
            catch
            {
                MessageBox.Show("Selected Null Table ");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                connection.GetConnection().Open();
                SqlCommand search = new SqlCommand("SELECT DISTINCT * FROM tbl_Company WHERE companyname like @p1", connection.GetConnection());
                search.Parameters.AddWithValue("@p1", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(search);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.GetConnection().Close();
                if (txtSearch.Text == null)
                {
                    Refreshtable();
                    list();
                }
            }
            catch
            {
                MessageBox.Show("Database Error");
            }
            finally
            {
                connection.GetConnection().Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cmbBoxCompanyName.Text) && !string.IsNullOrWhiteSpace(txtExplanation.Text))
                {
                    connection.GetConnection().Open();
                    SqlCommand newcompany = new SqlCommand("UPDATE tbl_Company SET companyname=@p2, explanation=@p3, result=@p4, [date]=@p5 ,username=@p6 WHERE id=@p1", connection.GetConnection());
                    newcompany.Parameters.AddWithValue("@p1", id);
                    newcompany.Parameters.AddWithValue("@p2", cmbBoxCompanyName.Text);
                    newcompany.Parameters.AddWithValue("@p3", txtExplanation.Text);
                    if (chkBoxResult.Checked) { newcompany.Parameters.AddWithValue("@p4", true); }
                    else { newcompany.Parameters.AddWithValue("@p4", false); }
                    newcompany.Parameters.Add("@p5", SqlDbType.Date).Value = DateTime.Now;
                    newcompany.Parameters.Add("@p6", SqlDbType.NVarChar).Value = getusername;
                    newcompany.ExecuteNonQuery();
                    connection.GetConnection().Close();
                    list();
                    Refreshtable();
                    clean();
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    

                }
                else
                {
                    MessageBox.Show("Please Fields All Lines");
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
                connection.GetConnection().Close();
            }



        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form report = new Report();
            report.ShowDialog();

           

        }
    }
}

