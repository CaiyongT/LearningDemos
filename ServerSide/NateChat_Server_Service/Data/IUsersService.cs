using NateChat_Server_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NateChat_Server_Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUsersService”。
    [ServiceContract]
    public interface IUsersService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [OperationContract]
        Users Login(Users users);//这里是以http协议操作数据库，所以可以带返回值。Tcp协议不能带返回值
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [OperationContract]
        Users Register(Users users);
        /// <summary>
        /// 根据登录人账号编号获取好友列表
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [OperationContract]
        List<Users> GetFriendsByUserId(Users users);
    }
}
