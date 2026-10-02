using Microsoft.EntityFrameworkCore;
using NnhStudentManager.Models;

namespace NnhStudentManager.Data
{
	public class NnhStudentManagerContext : DbContext
	{
		public NnhStudentManagerContext(
			DbContextOptions<NnhStudentManagerContext> nnhOptions)
			: base(nnhOptions)
		{
		}

		public DbSet<NnhStudentClass> NnhStudentClasses { get; set; }

		public DbSet<NnhStudent> NnhStudents { get; set; }

		public DbSet<NnhSubject> NnhSubjects { get; set; }

		public DbSet<NnhMark> NnhMarks { get; set; }

		protected override void OnModelCreating(ModelBuilder nnhModelBuilder)
		{
			base.OnModelCreating(nnhModelBuilder);

			// Khoa chinh ghep cho bang Marks
			nnhModelBuilder.Entity<NnhMark>()
				.HasKey(nnhMark => new
				{
					nnhMark.NnhSubjectId,
					nnhMark.NnhStudentId
				});

			// StudentClass - Student
			nnhModelBuilder.Entity<NnhStudent>()
				.HasOne(nnhStudent => nnhStudent.NnhStudentClass)
				.WithMany(nnhClass => nnhClass.NnhStudents)
				.HasForeignKey(nnhStudent => nnhStudent.NnhClassId)
				.OnDelete(DeleteBehavior.Restrict);

			// Student - Marks
			nnhModelBuilder.Entity<NnhMark>()
				.HasOne(nnhMark => nnhMark.NnhStudent)
				.WithMany(nnhStudent => nnhStudent.NnhMarks)
				.HasForeignKey(nnhMark => nnhMark.NnhStudentId)
				.OnDelete(DeleteBehavior.Cascade);

			// Subject - Marks
			nnhModelBuilder.Entity<NnhMark>()
				.HasOne(nnhMark => nnhMark.NnhSubject)
				.WithMany(nnhSubject => nnhSubject.NnhMarks)
				.HasForeignKey(nnhMark => nnhMark.NnhSubjectId)
				.OnDelete(DeleteBehavior.Cascade);

			// Email khong trung
			nnhModelBuilder.Entity<NnhStudent>()
				.HasIndex(nnhStudent => nnhStudent.NnhStudentEmail)
				.IsUnique();

			// Phone khong trung
			nnhModelBuilder.Entity<NnhStudent>()
				.HasIndex(nnhStudent => nnhStudent.NnhStudentPhone)
				.IsUnique();

			// Ten mon hoc khong trung
			nnhModelBuilder.Entity<NnhSubject>()
				.HasIndex(nnhSubject => nnhSubject.NnhSubjectName)
				.IsUnique();
		}
	}
}