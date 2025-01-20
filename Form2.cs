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
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=studentenrollmentdb;Username=Admin;Password=Skills12;";
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LoadRegNumbers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT RegNo FROM StudentRegistration";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) 
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            listBox.Items.Clear();
                            while (reader.Read())
                            {
                                listBox.Items.Add(reader["RegNo"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoadRegNumbers();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mobile_Click(object sender, EventArgs e)
        {

        }

        private void Mobiletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rlabel1_Click(object sender, EventArgs e)
        {

        }

    

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void txtHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelParentName_Click(object sender, EventArgs e)
        {

        }

        private void txtParentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNIC_Click(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoadRegNumbers();
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string mobileNo = txtMobile.Text;
                string homeNo = txtHome.Text;
                string parentName = txtParentName.Text;
                string nic = txtNIC.Text;
                string contactNo = txtContactNo.Text;

                DateTime dob = dtpDOB.Value;
                string gender = chkMale.Checked ? "Male" : chkFemale.Checked ? "Female" : null;

                if (string.IsNullOrEmpty(firstName) ||
                    string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(mobileNo) ||
                    string.IsNullOrEmpty(parentName) ||
                    string.IsNullOrEmpty(nic) ||
                    string.IsNullOrEmpty(contactNo) ||
                    gender == null)
                {
                    MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO StudentRegistration (FirstName, LastName, Email, Address, MobileNo, HomeNo, ParentName, NIC, ContactNo, Gender, DOB) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Address, @MobileNo, @HomeNo, @ParentName, @NIC, @ContactNo, @Gender, @DOB)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@MobileNo", mobileNo);
                        cmd.Parameters.AddWithValue("@HomeNo", homeNo);
                        cmd.Parameters.AddWithValue("@ParentName", parentName);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dob);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            chkMale.Checked = false;
            chkFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;
            txtFirstName.Focus();
    }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadRegNumbers();
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string mobileNo = txtMobile.Text;
                string homeNo = txtHome.Text;
                string parentName = txtParentName.Text;
                string nic = txtNIC.Text;
                string contactNo = txtContactNo.Text;
                DateTime dob = dtpDOB.Value;
                string gender = chkMale.Checked ? "Male" : chkFemale.Checked ? "Female" : null;

                if (string.IsNullOrEmpty(firstName) ||
                    string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(mobileNo) ||
                    string.IsNullOrEmpty(parentName) ||
                    string.IsNullOrEmpty(nic) ||
                    string.IsNullOrEmpty(contactNo) ||
                    gender == null)
                {
                    MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE StudentRegistration SET LastName=@LastName, Email=@Email, Address=@Address, MobileNo=@MobileNo, HomeNo=@HomeNo, ParentName=@ParentName, ContactNo=@ContactNo, Gender=@Gender, DOB=@DOB " +
                                   "WHERE FirstName=@FirstName AND NIC=@NIC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@MobileNo", mobileNo);
                        cmd.Parameters.AddWithValue("@HomeNo", homeNo);
                        cmd.Parameters.AddWithValue("@ParentName", parentName);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@NIC", nic);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("No record found to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadRegNumbers();
            try
            {
                string firstName = txtFirstName.Text;
                string nic = txtNIC.Text;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(nic))
                {
                    MessageBox.Show("Please provide the First Name and NIC to delete the record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM StudentRegistration WHERE FirstName=@FirstName AND NIC=@NIC";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@NIC", nic);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conn.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("No record found to delete.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                LoginForm loginForm = new LoginForm();
                loginForm.Show(); 
                this.Close();
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                          "Exit Application",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void StdRegGroup_Enter(object sender, EventArgs e)
        {

        }

        private void BasicDetailGroup_Enter(object sender, EventArgs e)
        {

        }

        private void ContactDetailsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxParentDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
