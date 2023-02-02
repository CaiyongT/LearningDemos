using System;
namespace NateChat_Server_Models.Models
{
	public class FriendRelation
	{
		 public int ID { get; set; }
		 public int UserID { get; set; }
		 public int FriendID { get; set; }
		 public DateTime CreateTime { get; set; }
	 }
}
