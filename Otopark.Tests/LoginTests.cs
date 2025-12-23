using otopark_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Login_WithCorrectCredentials_ShouldLogin()
        {
            
            LogIn login = new LogIn();

            login.tBox_user_name.Text = "ali";
            login.tBox_password.Text = "ali123";

            
            login.btn_login_Click(null, EventArgs.Empty);

            
            Assert.IsTrue(login.HasLoggedIn);
        }



        [TestMethod]
        public void Login_WithWrongCredentials_ShouldFail()
        {
            
            LogIn login = new LogIn();

            login.tBox_user_name.Text = "ali";
            login.tBox_password.Text = "wrongpass";

            
            login.btn_login_Click(null, EventArgs.Empty);

            
            Assert.IsFalse(login.HasLoggedIn);
        }
    }
}
