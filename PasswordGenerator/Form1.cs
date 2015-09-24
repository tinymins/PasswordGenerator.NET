using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;  
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generatePassword()
        {
            string salt = textSalt.Text.Trim();
            string account = textAccount.Text.Trim();
            if (salt.Equals("") || account.Equals(""))
                return;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] buffer = Encoding.Default.GetBytes(account + salt);
            buffer = md5.ComputeHash(buffer);
            buffer = md5.ComputeHash(buffer);
            buffer = md5.ComputeHash(buffer);
            string password = BitConverter.ToString(buffer).Replace("-", "").ToLower();
            password = password.Substring(1, 10);
            textPassword.Text = password;
        }

        private void textAccount_TextChanged(object sender, EventArgs e)
        {
            generatePassword();
        }
        
        private void textSalt_TextChanged(object sender, EventArgs e)
        {
            generatePassword();
        }
    }
}
