using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark_
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Username1 = "ali";
            Username2 = "mehmet";
            Username3= "hasan";
            HasLoggedIn = false;
        }
        private string username1;
        public string Username1
        {
            get { return username1; }
            set { username1 = value; }
        }

        





        private string username2;
        public  string Username2
        {
            get { return username2; }
            set { username2 = value; }
        }

        private string username3;
        public string Username3
        {
            get { return username3; }
            set { username3 = value; }
        }


        string password1 = "ali123";
        string password2 = "mehmet123";
        string password3 = "hasan123";


        private bool hasLoggedIn;
        public bool HasLoggedIn
        {
            get { return hasLoggedIn; }
            set { hasLoggedIn = value; }
        }





        private static string usernameinput;
        public static string Usernameinput
        {
            get { return usernameinput; }
            set { usernameinput = value; }
        }


        


        
        
        public string passwordinput;




        public void btn_login_Click(object sender, EventArgs e)
        {
            usernameinput = tBox_user_name.Text;
            passwordinput = tBox_password.Text;
            if (string.IsNullOrEmpty(usernameinput))
            {
                MessageBox.Show("You must enter your username");
                return;
            }
            foreach (var character in usernameinput)
            {
                               if (char.IsWhiteSpace(character))
                {
                    MessageBox.Show("Username cannot contain spaces");
                    return;
                }

            }

            if (string.IsNullOrEmpty(passwordinput))
            {
                MessageBox.Show("You must enter your password");
                return;
            }

            foreach (var character in passwordinput)
            {
                if (char.IsWhiteSpace(character))
                {
                    MessageBox.Show("Password cannot contain spaces");
                    return;
                }
            }
            if(usernameinput.Length < 3 || passwordinput.Length < 6)
            {
                MessageBox.Show("Username must be at least 3 characters long and password must be at least 6 characters long");
                return;
            }

            if ((usernameinput== username1 && passwordinput == password1) || (usernameinput == username2 && passwordinput == password2) || (usernameinput == username3 && passwordinput == password3))
            {
                
                HasLoggedIn = true;
                MessageBox.Show("User Login Completed!");
                
                this.Close(); 
                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                return;
            }



              



        }

       

        private void tBox_user_name_Click(object sender, EventArgs e)
        {
            
            if (tBox_user_name.Text == "  Username")
            {
                tBox_user_name.Clear();
                tBox_user_name.ForeColor = Color.Black;
            }
        }

        private void tBox_password_Click(object sender, EventArgs e)
        {
            
            if (tBox_password.Text == "  Password")
            {
                tBox_password.Clear();
                tBox_password.ForeColor = Color.Black;
            }
        }

        

       
    }
}
