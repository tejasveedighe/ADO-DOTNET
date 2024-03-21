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
                using (SqlConnection conn = new SqlConnection("Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
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

    }
}
