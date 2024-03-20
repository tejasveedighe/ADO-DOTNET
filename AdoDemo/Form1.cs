using Microsoft.Data.SqlClient;
using System.CodeDom;
using System.Data;

namespace AdoDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection("Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

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
}
