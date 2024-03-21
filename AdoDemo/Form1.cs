using Microsoft.Data.SqlClient;
// this class has the configuration manager
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace AdoDemo
{
    public partial class Form1 : Form
    {
        int PropertyId { get; set; }
        public Form1()
        {
            InitializeComponent();
            AddPropertyForm addPropertyForm = new AddPropertyForm();
            addPropertyForm.FormClosed += AddPropertyForm_FormClosed;
        }
        private void AddPropertyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Call the refreshBtn_Click method
            refreshBtn_Click(sender, e);
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
        }

        public void refreshBtn_Click(object sender, EventArgs e)
        {
            this.Form1_Load(sender, e);
            MessageBox.Show("Refresh Success");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // Get the cells of the double-clicked row
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Set the values of TextBox and ComboBox controls based on the cell values
                PropertyId = (int)row.Cells["PropertyId"].Value;
                property_title_txt.Text = row.Cells["PropertyTitle"].Value.ToString();
                type_cb.SelectedItem = row.Cells["PropertyType"].Value.ToString();
                property_location_txt.Text = row.Cells["Location"].Value.ToString();
                price_txt.Text = row.Cells["Price"].Value.ToString();
                bedroom_txt.Text = row.Cells["NoBedroom"].Value.ToString();
                bathroom_Txt.Text = row.Cells["NoBathroom"].Value.ToString();
                squareFeet_txt.Text = row.Cells["SquareFeet"].Value.ToString();
                status_cb.SelectedItem = row.Cells["Status"].Value.ToString();
                contact_txt.Text = row.Cells["ContactNumber"].Value.ToString();
                desc_txt.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                string query = @"UPDATE lpProperty 
                     SET PropertyTitle = @PropertyTitle, 
                         PropertyType = @PropertyType, 
                         Location = @Location, 
                         Price = @Price, 
                         NoBedroom = @NoBedroom, 
                         NoBathroom = @NoBathroom, 
                         SquareFeet = @SquareFeet, 
                         Description = @Description, 
                         Status = @Status, 
                         DateUpdated = @DateUpdated,
                         ContactNumber = @ContactNumber
                     WHERE PropertyId = @PropertyId";

                SqlCommand command = new SqlCommand(query, conn);
                // Add parameters to the command
                command.Parameters.AddWithValue("@PropertyTitle", property_title_txt.Text);
                command.Parameters.AddWithValue("@PropertyType", type_cb.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Location", property_location_txt.Text);
                command.Parameters.AddWithValue("@Price", price_txt.Text);
                command.Parameters.AddWithValue("@NoBedroom", bedroom_txt.Text);
                command.Parameters.AddWithValue("@NoBathroom", bathroom_Txt.Text);
                command.Parameters.AddWithValue("@SquareFeet", squareFeet_txt.Text);
                command.Parameters.AddWithValue("@Status", status_cb.SelectedItem.ToString());
                command.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                command.Parameters.AddWithValue("@PropertyId", PropertyId);
                command.Parameters.AddWithValue("@ContactNumber", contact_txt.Text);
                command.Parameters.AddWithValue("@Description", desc_txt.Text);

                try
                {
                    conn.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) updated.");
                    refreshBtn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                string query = @"DELETE FROM lpProperty WHERE PropertyId = @PropertyId";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@PropertyId", PropertyId);

                try
                {
                    conn.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) deleted.");
                    refreshBtn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
