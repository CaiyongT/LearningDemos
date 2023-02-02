using System;
using System.Runtime.Serialization;
namespace NateChat_Server_Models.Models
{
	[DataContract]
	public class Users
	 {
		/// <summary>
		/// �û�ID
		/// </summary>
		[DataMember]
		 public int UserID { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        [DataMember]
        public string Pwd { get; set; }
        /// <summary>
        /// �û��ǳ�
        /// </summary>
        [DataMember]
        public string NickName { get; set; }
        /// <summary>
        /// �û��Ա�
        /// </summary>
        [DataMember]
        public bool Sex { get; set; }
        /// <summary>
		/// �û��绰
		/// </summary>
		[DataMember]
        public string TelePhone { get; set; }
        /// <summary>
		/// �û�ͷ��
		/// </summary>
		[DataMember]
        public int ImageIndex { get; set; }
        /// <summary>
		/// �û��Ƿ���Ч
		/// </summary>
		[DataMember]
        public bool IsVaild { get; set; }
	 }
}
