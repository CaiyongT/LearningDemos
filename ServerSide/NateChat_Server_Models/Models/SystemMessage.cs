using System;
using static NateChat_Server_Models.CommonModel.CommonModel;

namespace NateChat_Server_Models.Models
{
	public class SystemMessage:BaseMessage
    {

		 public int ReciverID { get; set; }//接收人ID
		 public bool IsRecived { get; set; }//是否已接收
	 }
}
