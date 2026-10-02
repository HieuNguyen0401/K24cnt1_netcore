using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NnhStudentManager.Models
{
	[Table("Marks")]
	public class NnhMark
	{
		[Column("SubjectId")]
		public int NnhSubjectId { get; set; }

		[Column("StudentId")]
		public int NnhStudentId { get; set; }

		[Required(ErrorMessage = "Vui long nhap diem")]
		[Column("Score")]
		[Range(0, 10, ErrorMessage = "Diem phai tu 0 den 10")]
		public float NnhScore { get; set; }

		[ForeignKey("NnhSubjectId")]
		public virtual NnhSubject? NnhSubject { get; set; }

		[ForeignKey("NnhStudentId")]
		public virtual NnhStudent? NnhStudent { get; set; }
	}
}