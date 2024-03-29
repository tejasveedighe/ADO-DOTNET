using System.Data.SqlClient;
// this class has the configuration manager
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString;
                try
                {
                    string getPropertiesCommand = "SELECT * FROM lpProperty";

                    SqlCommand sqlCommand = new SqlCommand(getPropertiesCommand, conn);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString))
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
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString))
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

        private void contact_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void property_title_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(property_title_txt, e, "Property Title");
        }

        private void contact_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(contact_txt, e, "Contact Number");
        }

        private void squareFeet_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(squareFeet_txt, e, "Square Feet");
        }

        private void property_location_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(property_location_txt, e, "Location");
        }

        private void price_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(price_txt, e, "Price");
        }

        private void status_cb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateComboBox(status_cb, e, "Status");
        }

        private void bedroom_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(bedroom_txt, e, "Number of Bedrooms");
        }

        private void type_cb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateComboBox(type_cb, e, "Property Type");
        }

        private void bathroom_Txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(bathroom_Txt, e, "Number of Bathrooms");
        }

        private void desc_txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox(desc_txt, e, "Description");
        }

        private void ValidateTextBox(TextBox textBox, System.ComponentModel.CancelEventArgs e, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, fieldName + " cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void ValidateComboBox(ComboBox comboBox, System.ComponentModel.CancelEventArgs e, string fieldName)
        {
            if (comboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                comboBox.Focus();
                errorProvider1.SetError(comboBox, fieldName + " must be selected");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox, "");
            }
        }

    }
}
