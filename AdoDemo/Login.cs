using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void userEmail_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userEmail_txt.Text))
            {
                e.Cancel = true;
                userEmail_txt.Focus();
                errorProvider1.SetError(userEmail_txt, "Email cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(userEmail_txt, "");
            }
        }

        private void userPassword_txt_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(userPassword_txt.Text))
            {
                e.Cancel = true;
                userPassword_txt.Focus();
                errorProvider1.SetError(userPassword_txt, "Password cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(userPassword_txt, "");
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    btn.Enabled = false;
                    btn.Text = "Loggin in";

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbsc"].ConnectionString))
                    {
                        try
                        {
                            SqlCommand loginCommand = new SqlCommand("SELECT * from LpUser WHERE Email = @Email and Password = @Password", conn);

                            loginCommand.Parameters.AddWithValue("@Email", userEmail_txt.Text);
                            loginCommand.Parameters.AddWithValue("@Password", userPassword_txt.Text);

                            conn.Open();
                            SqlDataReader user = loginCommand.ExecuteReader();

                            if (user != null)
                            {
                                if (user.Read())
                                {
                                    Program.user = new Model.User
                                    {
                                        Id = (int)user["UserId"],
                                        Name = user["Name"].ToString(),
                                        Email = user["Email"].ToString(),
                                        UserType = user["UserType"].ToString(),
                                        Phone = user["Phone"].ToString(),
                                    };
                                }
                                MessageBox.Show($"Login Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 form1 = new Form1();
                                form1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login Failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            btn.Enabled = true;
                            btn.Text = "Sign In";
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void forgetPass_label_Click(object sender, EventArgs e)
        {

        }

        private void register_label_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        private void crossLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
