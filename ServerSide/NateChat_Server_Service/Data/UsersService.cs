using NateChat_Server_BLL;
using NateChat_Server_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NateChat_Server_Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“UsersService”。
    public class UsersService : IUsersService
    {
        UserManager userManager = new UserManager();

        public List<Users> GetFriendsByUserId(Users users)
        {
            //在这里面调用业务逻辑层代码
            return null;
        }

        public Users Login(Users users)
        {
            ///调用业务逻辑层代码，在这里加密最好
            return userManager.Login(users);
        }

        public Users Register(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
