using System;
using System.Threading;
using System.Windows.Forms;

namespace loan_simulator
{
    public partial class CAdminPanel : Form
    {
        public CAdminPanel()
        {
            InitializeComponent();
            this.Text = "admin panel";
        }

        // Event handler for logout button - closes the admin panel
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event handler for the change button
        private void btn_change_Click(object sender, EventArgs e)
        {
            // If edit mode is enabled, open CMainPanel with editable fields
            if (editBox.Checked)
            {
                OpenMainPanel(new CMainPanel(true));
            }
            else
            {
                // Parse interest rate from input box
                if (float.TryParse(interesetBox.Text, out float interestRate))
                {
                    CInterestRate insRate1 = new CInterestRate(interestRate);
                    OpenMainPanel(new CMainPanel(interestRate));
                }
                else
                {
                    MessageBox.Show("Please enter a valid interest rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Helper method to open a new instance of CMainPanel in a separate thread
        private void OpenMainPanel(Form mainPanel)
        {
            Thread newThread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Application.Run(mainPanel);
            });

            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
    }
}
