using System;
using System.Runtime.Serialization;
namespace NateChat_Server_Models.Models
{
	[DataContract]
	public class Users
	 {
		/// <summary>
		/// 用户ID
		/// </summary>
		[DataMember]
		 public int UserID { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [DataMember]
        public string Pwd { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        [DataMember]
        public string NickName { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        [DataMember]
        public bool Sex { get; set; }
        /// <summary>
		/// 用户电话
		/// </summary>
		[DataMember]
        public string TelePhone { get; set; }
        /// <summary>
		/// 用户头像
		/// </summary>
		[DataMember]
        public int ImageIndex { get; set; }
        /// <summary>
		/// 用户是否有效
		/// </summary>
		[DataMember]
        public bool IsVaild { get; set; }
	 }
}
