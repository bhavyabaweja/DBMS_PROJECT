using FitnessCentreApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FitnessCentre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text.Trim();
            string password = passwordtb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM User WHERE Username = @username AND Password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show($"Login successful! Role: {role}");

                            // Navigate based on role
                            switch (role)
                            {
                                case "Admin":
                                    // Open Admin Dashboard
                                    new AdminDashboard().Show();
                                    break;
                                case "Member":
                                    // Open Member Dashboard
                                    new MemberDashboard().Show();
                                    break;
                                case "Trainer":
                                    // Open Trainer Dashboard
                                    new TrainerDashboard().Show();
                                    break;
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
