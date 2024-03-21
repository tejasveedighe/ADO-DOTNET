using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AdoDemo
{
    public partial class AddPropertyForm : Form
    {
        public AddPropertyForm()
        {
            InitializeComponent();
        }

        private void AddPropertyForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProp_crossLabel_Click(object sender, EventArgs e)
        {
            AddPropertyForm.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString))
                {
                    try
                    {
                        string cmd = "INSERT INTO lpProperty (PropertyTitle, PropertyType, Location, Price, NoBedroom, NoBathroom ,SquareFeet, Description, ContactNumber, Status, DateListed, DateUpdated, UserId, Approved) VALUES (@PropertyTitle, @PropertyType, @Location,  @Price, @NoBedroom, @NoBathroom, @SquareFeet, @Description, @ContactNumber,  @Status, @DateListed, @DateUpdated, @UserId, @Approved)";

                        SqlCommand sqlCommand = new SqlCommand(cmd, conn);
                        conn.Open();

                        sqlCommand.Parameters.AddWithValue("@PropertyTitle", propertyTitle_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@PropertyType", propertyType_cb.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@Location", location_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@Price", price_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@NoBedroom", bedroom_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@NoBathroom", bathroom_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@SquareFeet", squareFeet_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@Description", description_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@ContactNumber", "123");
                        sqlCommand.Parameters.AddWithValue("@Status", status_cb.Text);
                        sqlCommand.Parameters.AddWithValue("@DateListed", DateTime.Now.ToString());
                        sqlCommand.Parameters.AddWithValue("@DateUpdated", DateTime.Now.ToString());
                        sqlCommand.Parameters.AddWithValue("@UserId", "4");
                        sqlCommand.Parameters.AddWithValue("@Approved", false);


                        int affectedRows = sqlCommand.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Property was added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddPropertyForm.ActiveForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("Unable to add Property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            TextBox td = sender as TextBox;
            if (td != null)
            {
                if (td.Text.Length > 0)
                {
                    e.Cancel = false;
                    errorProvider1.SetError(td, "Input Cannot be empty");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(td, "");
                }
            }
        }

        private void propertyTitle_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void propertyTitle_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(propertyTitle_txt, e, "Property Title");
        }

        private void squareFeet_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(squareFeet_txt, e, "Square Feet");
        }

        private void location_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(location_txt, e, "Location");
        }

        private void price_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(price_txt, e, "Price");
        }

        private void bedroom_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(bedroom_txt, e, "Number of Bedrooms");
        }

        private void bathroom_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(bathroom_txt, e, "Number of Bathrooms");
        }

        private void propertyType_cb_Validating(object sender, CancelEventArgs e)
        {
            ValidateComboBox(propertyType_cb, e, "Property Type");
        }

        private void status_cb_Validating(object sender, CancelEventArgs e)
        {
            ValidateComboBox(status_cb, e, "Status");
        }

        private void description_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(description_txt, e, "Description");
        }

        public void ValidateTextBox(TextBox textBox, CancelEventArgs e, string fieldName)
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

        public void ValidateComboBox(ComboBox comboBox, CancelEventArgs e, string fieldName)
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
