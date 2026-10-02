using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NnhStudentManager.Models
{
	[Table("StudentClass")]
	public class NnhStudentClass
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "Vui long nhap ten lop")]
		[StringLength(100)]
		[Column("ClassName", TypeName = "nvarchar(100)")]
		public string NnhClassName { get; set; } = string.Empty;

		public virtual ICollection<NnhStudent> NnhStudents { get; set; }
			= new List<NnhStudent>();
	}
}