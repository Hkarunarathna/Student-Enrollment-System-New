using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace StudentEnrollmentSystem
{

	public partial class LoginForm : Form
	{
		private string connectionString = "Server=localhost;Port=3306;Database=studentenrollmentdb;Username=Admin;Password=Skills12;";
		public LoginForm()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			txtusername.Focus();
		}
		private void txtpassword_TextChanged(object sender, EventArgs e)
		{
			InitializeComponent();
			txtpassword.PasswordChar = '*';
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtusername.Text = string.Empty;
			txtpassword.Text = string.Empty;
			txtusername.Focus();
		}

		private void label1_Click_1(object sender, EventArgs e)
		{
		}
		private void label2_Click(object sender, EventArgs e)
		{
		}
		private void txtusername_TextChanged(object sender, EventArgs e)
		{
		}
		private void username_Click(object sender, EventArgs e)
		{

		}

		private void password_Click(object sender, EventArgs e)
		{

		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
			{
				MessageBox.Show("Please enter both username and password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (MySqlConnection conn = new MySqlConnection(connectionString))
				{
					conn.Open();
					string query = "SELECT COUNT(*) FROM Users WHERE BINARY Username = @username AND BINARY Password = @password";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
						cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

						int userCount = Convert.ToInt32(cmd.ExecuteScalar());

						if (userCount > 0)
						{
							MessageBox.Show("Login Successful");
						}
						else
						{
							MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show($"Database connection failed: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegistrationForm registrationForm = new RegistrationForm();
			registrationForm.Show(); 
			this.Hide(); 
		}



		private void lblRegister_Click(object sender, EventArgs e)
			{
			RegistrationForm registrationForm = new RegistrationForm();
			registrationForm.Show();
			this.Hide();
		}
    }
}

