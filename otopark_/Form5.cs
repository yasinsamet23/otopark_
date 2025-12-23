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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void listBox_error_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tüm hatalar burda listelenecek ör.parola eksik/yanlış, gün sonu raporu almadan çıkış yapamazsınız, giriş yapmadan ödeme alamazsınız vb...
        }
    }
}
