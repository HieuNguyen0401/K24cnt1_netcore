using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLab6_EF.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
		[StringLength(150)]
		public string Name { get; set; } = string.Empty;

		[StringLength(200)]
		public string Image { get; set; } = string.Empty;

		[Required(ErrorMessage = "Giá sản phẩm không được để trống!")]
		public float Price { get; set; }

		public float SalePrice { get; set; }

		[Column(TypeName = "tinyint")]
		public byte Status { get; set; }

		[StringLength(2000, ErrorMessage = "Nội dung mô tả giới hạn 2000 ký tự!")]
		[Column(TypeName = "ntext")]
		public string Description { get; set; } = string.Empty;

		[Required(ErrorMessage = "Danh mục sản phẩm không được để trống!")]
		public int CategoryID { get; set; }

		public DateTime CreationDate { get; set; }

		[ForeignKey("CategoryID")]
		public NnhCategory? NnhCategory { get; set; }
	}
}