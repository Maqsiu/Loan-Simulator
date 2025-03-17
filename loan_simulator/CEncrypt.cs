using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loan_simulator
{
    internal class CEncrypt
    {
        string password;

        // Constructor to initialize the password
        public CEncrypt(string pass) {
        this.password = pass;
        }


        // Hardcoded credentials for login
        //login: admin
        //password: admin


        // Function to decrypt password by shifting characters back
        public bool decryptPassword()
        {
            StringBuilder dPass = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                char pasek = (char)(password[i] + 2);
                dPass.Append(pasek);
            }

            // Check if decrypted password matches "cfokp" (which is "admin" shifted)
            return dPass.ToString() == "cfokp";


        }


    }
}
