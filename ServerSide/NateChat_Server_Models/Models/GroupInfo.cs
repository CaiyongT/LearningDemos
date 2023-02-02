using System;
namespace NateChat_Server_Models.Models
{
	public class GroupInfo
    {
		 public int GroupID { get; set; }
		 public int CreatorID { get; set; }
		 public string GroupName { get; set; }
		 public DateTime CreateTime { get; set; }
		 public string GroupInfos { get; set; }
		 public bool IsVaild { get; set; }
	 }
}
