using System;
using static NateChat_Server_Models.CommonModel.CommonModel;

namespace NateChat_Server_Models.Models
{
	public class GroupMessage:BaseMessage
	{
		 public int ReciverGroupID { get; set; }//接收群的ID
	 }
}
