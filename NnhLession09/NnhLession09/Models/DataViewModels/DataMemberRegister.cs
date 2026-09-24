using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NnhLession09.Models.DataViewModels
{
	public class NnhMemberRegister
	{
		public int NnhMemberId { get; set; }

		[DisplayName("Tên đăng nhập")]
		[Required(ErrorMessage = "Tên đăng nhập không để trống")]
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 3 - 20 ký tự")]
		public string NnhUserName { get; set; }

		[DisplayName("Mật khẩu")]
		[Required(ErrorMessage = "Mật khẩu không được để trống")]
		[DataType(DataType.Password)]
		public string NnhPassword { get; set; }

		[DisplayName("Email")]
		public string NnhEmail { get; set; }

		[DisplayName("Số điện thoại")]
		public string NnhPhoneNumber { get; set; }

		[DisplayName("Họ và tên")]
		public string NnhFullName { get; set; }

		[DisplayName("Ngày sinh")]
		public DateTime NnhBirthday { get; set; }
	}
}