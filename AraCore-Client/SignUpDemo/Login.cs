using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using AraCore;
using System.Net;
using System.Collections.Specialized;
using System.Net.Sockets;

namespace SignUpDemo
{
    public partial class Login : Form
    {
        string WHusername = "AraCore Client Logs";
        string WHavatar = "https://cdn.discordapp.com/attachments/605044891839365132/709708459528159252/aracore.png";//Discord Avatar URL
        string WHurl = ""; //Discord Webhook URL
        string time = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");

        public Login()
        {
            InitializeComponent();
            AraCore.Handler.Initialize();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
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
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Enter a Username & Password!", "AraCore Client");
                return;
            }
            
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; 
            bool response = Handler.Login(login_username.Text, login_password.Text);
            if (response)
            {
                sendWebHook(WHurl, $"```diff\n- [NEW LOGIN] {time} " + "User: " + login_username.Text + "```", WHusername, WHavatar);
                Handler.Log(login_username.Text, " Signed In");

                Dashboard form = new Dashboard();
                this.Hide(); 
                form.Show();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
