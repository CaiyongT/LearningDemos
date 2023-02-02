using System;
namespace NateChat_Server_Models.Models
{
	public class Users
	 {
		 public int UserID { get; set; }
		 public string Pwd { get; set; }
		 public string NickName { get; set; }
		 public bool Sex { get; set; }
		 public string TelePhone { get; set; }
		 public int ImageIndex { get; set; }
		 public bool IsVaild { get; set; }
	 }
}
