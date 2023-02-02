using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NateChat_Server_Models.CommonModel
{
    public class CommonModel
    {
        /// <summary>
        /// 信息类父类
        /// </summary>
        [DataContract]///此数据契约表示此基类对外开放，可以在客户端引用此基类
        public class BaseMessage 
        {
            /// <summary>
            /// 信息ID
            /// </summary>
            [DataMember]
            public int MessageID { get; set; }
            /// <summary>
            /// 发送人ID
            /// </summary>
            [DataMember]
            public int SenderID { get; set; }
            /// <summary>
            /// 发送时间
            /// </summary>
            [DataMember]
            public DateTime SendTime { get; set; }
            /// <summary>
            /// 发送内容
            /// </summary>
            [DataMember]            
            public string MessageContent { get; set; }
            /// <summary>
            /// 是否有效
            /// </summary>
            [DataMember]
            public bool IsValid { get; set; }
        }
    }
}
