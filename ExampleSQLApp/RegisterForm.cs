using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            loginRegField.ForeColor = Color.Gray;
            loginRegField.Text = "Enter your login";

            passwordRegField.UseSystemPasswordChar = false;
            passwordRegField.ForeColor = Color.Gray;
            passwordRegField.Text = "Enter your password";

            passwordConfirmField.UseSystemPasswordChar = false;
            passwordConfirmField.ForeColor = Color.Gray;
            passwordConfirmField.Text = "Repeate your password";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginRegField_Enter(object sender, EventArgs e)
        {
            if (loginRegField.Text == "Enter your login")
            {
                loginRegField.ForeColor = Color.Black;
                loginRegField.Text = "";
            }
        }

        private void passwordRegField_Enter(object sender, EventArgs e)
        {
            if (passwordRegField.Text == "Enter your password")
            {
                passwordRegField.UseSystemPasswordChar = true;
                passwordRegField.ForeColor = Color.Black;
                passwordRegField.Text = "";
            }
        }

        private void passwordConfirmField_Enter(object sender, EventArgs e)
        {
            if (passwordConfirmField.Text == "Repeate your password")
            {
                passwordConfirmField.UseSystemPasswordChar = true;
                passwordConfirmField.ForeColor = Color.Black;
                passwordConfirmField.Text = "";
            }
        }

        private void loginRegField_Leave(object sender, EventArgs e)
        {
            if (loginRegField.Text == "")
            {
                loginRegField.ForeColor = Color.Gray;
                loginRegField.Text = "Enter your login";
            }
        }

        private void passwordRegField_Leave(object sender, EventArgs e)
        {
            if (passwordRegField.Text == "")
            {
                passwordRegField.UseSystemPasswordChar = false;
                passwordRegField.ForeColor = Color.Gray;
                passwordRegField.Text = "Enter your password";
            }
        }

        private void passwordConfirmField_Leave(object sender, EventArgs e)
        {
            if (passwordConfirmField.Text == "")
            {
                passwordConfirmField.UseSystemPasswordChar = false;
                passwordConfirmField.ForeColor = Color.Gray;
                passwordConfirmField.Text = "Repeate your password";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(loginRegField.Text == "Enter your login")
            {
                MessageBox.Show("Enter your login, please");
                return;
            }

            if(passwordRegField.Text == "Enter your password")
            {
                MessageBox.Show("Enter your password, please");
                return;
            }

            if(passwordConfirmField.Text == "Repeate your password")
            {
                MessageBox.Show("Repeat your password, please");
                return;
            }

            if(isUserExists())
                return;

            if (passwordRegField.Text == passwordConfirmField.Text)
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@uL, @uP)", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginRegField.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordRegField.Text;

                db.openConnection();

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account was created");
                }
                else 
                {
                    MessageBox.Show("Oops! Something went wrong");
                }

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Passwords don't match!");
            }
        }

        private Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginRegField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User with the same login is already exists");
                return true;
            }
            return false;
        }
    }
}
