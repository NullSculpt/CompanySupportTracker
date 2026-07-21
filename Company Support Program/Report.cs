using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Company_Support_Program
{
    public partial class Report : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'companySupportDataSet.tbl_Company' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_CompanyTableAdapter.Fill(this.companySupportDataSet.tbl_Company);
            
            list();

            this.reportViewer1.RefreshReport();

           
        }
        private void list()
        {
            try
            {

                cmbCompany.Items.Clear();
                connection.GetConnection().Open();
                SqlCommand companyname = new SqlCommand("SELECT DISTINCT companyname FROM tbl_Company ", connection.GetConnection());
                SqlDataReader companynamedr = companyname.ExecuteReader();
                while (companynamedr.Read())
                {
                    cmbCompany.Items.Add(companynamedr[0].ToString());
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

        public void filter()
        {
            if (startdate.Value.Date > endDate.Value.Date)
            {
                MessageBox.Show("Start date cannot be greater than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    connection.GetConnection().Open();
                    SqlCommand search = new SqlCommand("SELECT * FROM tbl_Company where companyname like @p1 AND [date] BETWEEN @p2 AND @p3 ", connection.GetConnection());
                    search.Parameters.AddWithValue("@p1", "%" + cmbCompany.Text + "%");
                    search.Parameters.Add("@p2", SqlDbType.Date).Value = startdate.Value.Date;
                    search.Parameters.Add("@p3", SqlDbType.Date).Value = endDate.Value.Date;
                    SqlDataAdapter da = new SqlDataAdapter(search);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    companySupportDataSetBindingSource.DataSource = dt;
                    

                    this.reportViewer1.RefreshReport();
                }
                finally
                {
                    connection.GetConnection().Close();
                }
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.tbl_CompanyTableAdapter.Fill(this.companySupportDataSet.tbl_Company);
            companySupportDataSetBindingSource.DataSource = this.companySupportDataSet.tbl_Company; 
            this.reportViewer1.RefreshReport();
        }
    }
}
