using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NnhStudentManager.Models
{
	[Table("Student")]
	public class NnhStudent
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "Vui long nhap ten sinh vien")]
		[StringLength(100)]
		[Column("StudentName", TypeName = "nvarchar(100)")]
		public string NnhStudentName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Vui long nhap email")]
		[EmailAddress(ErrorMessage = "Email khong dung dinh dang")]
		[StringLength(100)]
		[Column("StudentEmail", TypeName = "nvarchar(100)")]
		public string NnhStudentEmail { get; set; } = string.Empty;

		[Required(ErrorMessage = "Vui long nhap so dien thoai")]
		[StringLength(50)]
		[Column("StudentPhone", TypeName = "nvarchar(50)")]
		public string NnhStudentPhone { get; set; } = string.Empty;

		[Required(ErrorMessage = "Vui long nhap dia chi")]
		[StringLength(150)]
		[Column("StudentAddress", TypeName = "nvarchar(150)")]
		public string NnhStudentAddress { get; set; } = string.Empty;

		[Required(ErrorMessage = "Vui long nhap avatar")]
		[StringLength(100)]
		[Column("StudentAvatar", TypeName = "nvarchar(100)")]
		public string NnhStudentAvatar { get; set; } = string.Empty;

		[Required(ErrorMessage = "Vui long chon ngay sinh")]
		[Column("StudentBirthday", TypeName = "date")]
		public DateTime NnhStudentBirthday { get; set; }

		[Required(ErrorMessage = "Vui long chon lop")]
		[Column("ClassId")]
		public int NnhClassId { get; set; }

		[ForeignKey("NnhClassId")]
		public virtual NnhStudentClass? NnhStudentClass { get; set; }

		public virtual ICollection<NnhMark> NnhMarks { get; set; }
			= new List<NnhMark>();
	}
}