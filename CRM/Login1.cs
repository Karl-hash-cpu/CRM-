using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Login1 : Form
    {
        private string userFile = "users.txt";
        public Login1()
        {
            InitializeComponent();
            if (!File.Exists(userFile))
            {
                File.Create(userFile).Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Check if fields are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields!", "Error");
                    return;
                }

                // Check if user exists
                if (CheckUser(username, password))
                {
                    MessageBox.Show("Welcome " + username + "!", "Success");
                    // Add code here for what happens after successful login
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error");
                }
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Check if fields are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields!", "Error");
                    return;
                }

                // Check if username already exists
                if (UsernameExists(username))
                {
                    MessageBox.Show("Username already exists!", "Error");
                    return;
                }

                // Save new user
                SaveUser(username, password);
                MessageBox.Show("Account created successfully!", "Success");
            }
        }


        // Helper method to check if user exists
        private bool CheckUser(string username, string password)
        {
            string[] lines = File.ReadAllLines(userFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        // Helper method to check if username exists
        private bool UsernameExists(string username)
        {
            string[] lines = File.ReadAllLines(userFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == username)
                {
                    return true;
                }
            }
            return false;
        }

        // Helper method to save new user
        private void SaveUser(string username, string password)
        {
            using (StreamWriter sw = File.AppendText(userFile))
            {
                sw.WriteLine($"{username},{password}");
            }
        }
    }
}
    
