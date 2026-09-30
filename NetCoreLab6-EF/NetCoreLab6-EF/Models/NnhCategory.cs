using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreLab6_EF.Models
{
	public class NnhCategory
	{
		[Key]
		public int NnhId { get; set; }

		[Required(ErrorMessage = "Tên danh mục không được để trống")]
		[Display(Name = "Tên danh mục")]
		public string NnhName { get; set; } = string.Empty;

		[Display(Name = "Trạng thái")]
		public byte NnhStatus { get; set; }

		[Display(Name = "Ngày tạo")]
		public DateTime NnhCreatedDate { get; set; }

		public ICollection<Product> Products { get; set; } = new List<Product>();
	}
}