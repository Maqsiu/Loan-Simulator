using System;
using System.Threading;
using System.Windows.Forms;

namespace loan_simulator
{
    public partial class CLogScreen : Form
    {
        public CLogScreen()
        {
            InitializeComponent();
            this.Text = "log screen";
        }

        // Event handler for login button click
        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string password = passwordText.Text;
            CEncrypt pass = new CEncrypt(password);

            // Check if login or password fields are empty
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login or password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate credentials
            if (login == "admin" && pass.decryptPassword())
            {
                MessageBox.Show("Successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Admin Panel in a new thread
                Thread newThreadPanel = new Thread(() =>
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.EnableVisualStyles();
                    Application.Run(new CAdminPanel());
                });

                newThreadPanel.SetApartmentState(ApartmentState.STA);
                newThreadPanel.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect login details", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
