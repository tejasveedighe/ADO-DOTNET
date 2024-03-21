using Microsoft.Data.SqlClient;
// this class has the configuration manager
using System.Configuration;
using System.Data;

namespace AdoDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
                try
                {
                    string getPropertiesCommand = "SELECT * FROM lpProperty";

                    SqlCommand sqlCommand = new SqlCommand(getPropertiesCommand, conn);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void users_tab_Click(object sender, EventArgs e)
        {

        }

        private void properties_add_property_btn_Click(object sender, EventArgs e)
        {
            new AddPropertyForm().Show();
            //using (SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = "Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}


        }
    }
}
