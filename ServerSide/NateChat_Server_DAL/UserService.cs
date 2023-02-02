using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NateChat_Server_Models;
using NateChat_Server_Models.Models;
using System.Data.SqlClient;
using NateChat_Server_Common;

namespace NateChat_Server_DAL
{
    /// <summary>
    /// 用户数据服务类
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Users LoginCheck(Users user) 
        {
            string sql = "Select * From Users where UserID = @userID and Pwd = @pwd";
            SqlParameter[] sqlParameter = {
                new SqlParameter("@userID",user.UserID),
                new SqlParameter("@pwd",user.Pwd)
            };
          return  DBHelper.GetModel<Users>(sql, sqlParameter);
        }
    }
}
