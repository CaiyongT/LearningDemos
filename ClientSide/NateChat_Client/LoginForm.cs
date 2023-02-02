using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NateChat_Client.ServerService.UserService;
namespace NateChat_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建用户服务对象
        /// </summary>
        UsersServiceClient userService = new UsersServiceClient();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.UserID = int.Parse(txb_Acc.Text.Trim());
            users.Pwd= txb_Pwd.Text.Trim().ToString();
            Users loginUser = userService.Login(users);
            if (loginUser!=null)
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid account or password!");
            }
        }
    }
}
