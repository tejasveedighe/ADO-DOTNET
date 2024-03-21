using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AdoDemo
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void crossLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_user_btn_Click(object sender, EventArgs e)
        {
            Button? bt = sender as Button;
            bt.Text = "Loading";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString))
                {
                    try
                    {
                        string registerUserCommand = "INSERT INTO LpUser (Name, Email, Password, UserType, Phone) VALUES (@Name, @Email, @Password, @UserType, @Phone)";

                        SqlCommand cmd = new SqlCommand(registerUserCommand, conn);
                        cmd.Parameters.AddWithValue("@Name", register_name_txt.Text);
                        cmd.Parameters.AddWithValue("@Email", register_email_txt.Text);
                        cmd.Parameters.AddWithValue("@Password", register_pass_txt.Text);
                        cmd.Parameters.AddWithValue("@UserType", register_buyer_radio.Checked ? "Buyer" : "Seller");
                        cmd.Parameters.AddWithValue("@Phone", register_phone_txt.Text);

                        conn.Open();
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("User Registered Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed To register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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
            bt.Text = "Register";
            Register.ActiveForm.Close();
        }

        private void register_repass_txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    e.Cancel = true;
                    tb.Focus();
                    errorProvider1.SetError(tb, "Input cannot be empty");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tb, "");
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {


        }

        private void register_name_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(register_name_txt, e, "Name");
        }

        private void register_email_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(register_email_txt, e, "Email");
        }

        private void register_phone_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(register_phone_txt, e, "Phone Number");
        }

        private void register_pass_txt_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(register_pass_txt, e, "Password");
        }

        private void register_buyer_radio_Validating(object sender, CancelEventArgs e)
        {
            ValidateRadioButtonSelection(register_buyer_radio, register_seller_radio, e, "User Type");
        }

        private void register_seller_radio_Validating(object sender, CancelEventArgs e)
        {
            ValidateRadioButtonSelection(register_seller_radio, register_buyer_radio, e, "User Type");
        }

        private void ValidateTextBox(TextBox textBox, CancelEventArgs e, string fieldName)
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

        private void ValidateRadioButtonSelection(RadioButton radioButton, RadioButton otherRadioButton, CancelEventArgs e, string fieldName)
        {
            if (!radioButton.Checked && !otherRadioButton.Checked)
            {
                e.Cancel = true;
                radioButton.Focus();
                errorProvider1.SetError(radioButton, fieldName + " must be selected");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(radioButton, "");
            }
        }

        private void register_phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }
    }
}
