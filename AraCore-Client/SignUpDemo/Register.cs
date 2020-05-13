using AraCore;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class Register : Form
    {
        string WHusername = "AraCore Client Logs";
        string WHavatar = "https://cdn.discordapp.com/attachments/605044891839365132/709708459528159252/aracore.png";//Discord Avatar URL
        string WHurl = ""; //Discord Webhook URL
        string time = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");

        public Register()
        {
            InitializeComponent();
            AraCore.Handler.Initialize(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        public static void sendWebHook(string URL, string msg, string username, string avatar_url)
        {
            _ = Http.Post(URL, new NameValueCollection()
        {
                {
                    "username",
                    username

                },
                {
                    "avatar_url",
                    avatar_url

                },
                {
                    "content",
                    msg
                },


            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == false)
            {
                MessageBox.Show("Please Accept our Terms & Rules to continue", "AraCore Client");
                return;
            }
            string username = register_username.Text;
            string password = register_password.Text;
            string email = register_email.Text;
            string license = register_license.Text;
            bool register = AraCore.Handler.Register(username, password, email, license); 
            if (register)
            {
                sendWebHook(WHurl, $"```diff\n- [NEW REGISTRATION] {time} " + "User: " + username + "\n- Email: " + email + "\n- License: " + license + "```", WHusername, WHavatar);
                Thread.Sleep(1000);
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to Register, Contact an Admin!");
            }
        }
    }
}
