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

                using (SqlConnection conn = new SqlConnection("Data Source=SQL12-16-LATEST\\SQL2016;Initial Catalog=SNW;User ID=nagesh;Password=Download@1;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
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

        private void register_seller_radio_Validating(object sender, CancelEventArgs e)
        {
            CheckBox? cb = sender as CheckBox;
            if (cb != null)
            {

                if (cb.Checked == false)
                {
                    e.Cancel = true;
                    cb.Focus();
                    errorProvider1.SetError(cb, "One must be selected");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cb, "");
                }
            }
        }
    }
}
