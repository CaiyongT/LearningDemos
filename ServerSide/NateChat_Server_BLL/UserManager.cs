using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NateChat_Server_DAL;
using NateChat_Server_Models.Models;

namespace NateChat_Server_BLL
{
    /// <summary>
    /// 用户业务管理类
    /// </summary>
    public class UserManager
    {
        UserService userService = new UserService();
        public Users Login(Users users) 
        {
            return userService.LoginCheck(users);
        }
    }
}
