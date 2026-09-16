using System.ComponentModel;

namespace NnhLession08Models.Models
{
	public class NnhMember
	{
		public string NnhMemberId { get; set; } = "";
		public string NnhUserName { get; set; } = "";
		public string NnhPassword { get; set; } = "";

		public string NnhEmail { get; set; } = "";

		[DisplayName("Họ Và tên ")]
		public string NnhFullname { get; set; } = "";
	}
}