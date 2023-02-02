﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NateChat_Server_Service.Data
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IGroupService”。
    [ServiceContract]
    public interface IGroupService
    {
        [OperationContract]
        void DoWork();
    }
}
