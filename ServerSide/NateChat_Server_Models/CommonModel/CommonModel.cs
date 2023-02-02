using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NateChat_Server_Models.CommonModel
{
    public class CommonModel
    {
        /// <summary>
        /// 信息类父类
        /// </summary>
        public class BaseMessage 
        {
            public int MessageID { get; set; }//信息ID
            public int SenderID { get; set; }//发送人ID
            public DateTime SendTime { get; set; }//发送时间
            public string MessageContent { get; set; }//发送内容
            public bool IsValid { get; set; }//是否有效
        }
    }
}
