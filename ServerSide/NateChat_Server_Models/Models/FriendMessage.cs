using System;
using static NateChat_Server_Models.CommonModel.CommonModel;
namespace NateChat_Server_Models.Models
{
	public class FriendMessage:BaseMessage
    {		 
		 public int ReciverID { get; set; }//接收人编号
		 public bool IsRecived { get; set; }//是否接收
	}
}
