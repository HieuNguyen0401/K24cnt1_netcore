using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NnhStudentManager.Models
{
	[Table("Subjects")]
	public class NnhSubject
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "Vui long nhap ten mon hoc")]
		[StringLength(100)]
		[Column("SubjectName", TypeName = "nvarchar(100)")]
		public string NnhSubjectName { get; set; } = string.Empty;

		public virtual ICollection<NnhMark> NnhMarks { get; set; }
			= new List<NnhMark>();
	}
}