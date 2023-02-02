using NateChat_Server_Common;
using NateChat_Server_Service;
using NateChat_Server_Service.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NateChat_Server_UI
{
    public partial class Server_Main : Form
    {
        List<ServiceHost> serviceHosts= new List<ServiceHost>() 
        {  
           new ServiceHost(typeof(UsersService)),
           new ServiceHost(typeof(GroupService)),
           new ServiceHost(typeof(ChatService))
        };
        public Server_Main()
        {
            InitializeComponent();
        }
        ///创建服务主机

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ServiceHost host in serviceHosts)
                {
                    host.Open();
                }
                lbl_State.Text = "启动";
                lbl_State.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LogHelper.Error("启动服务：", ex);
            }
            
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ServiceHost host in serviceHosts)
                {
                    host.Open();
                }
                lbl_State.Text = "关闭";
                lbl_State.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                LogHelper.Error("关闭服务：",ex);
            }
            
        }
    }
}
