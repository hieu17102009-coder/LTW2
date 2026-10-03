using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NVH_NETCORE_MVC_BTLab05.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        [Display(Name="Tên sản phẩm")]
        [Length(6,120,ErrorMessage ="Tên sản phẩm phải bao gồm từ 6 đến 150 ký tự")]
        public string Name { get; set; }
        
        //[Required(ErrorMessage = "Bạn cần upload ảnh sản phẩm")]
        [NotMapped]
        public IFormFile? Fimage { get; set; }
        [Display(Name = "Ảnh sản phẩm")]
        public string? Image {  get; set; }
        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        [DataType(DataType.Text)]
        [Range(100000,float.MaxValue,ErrorMessage ="Giá sản phẩm phải lớn hơn hoặc bằng 100000")]
        public float Price {  get; set; }
        [Required(ErrorMessage ="Không được để trống giá trị giảm")]
        [Range(0,float.MaxValue,ErrorMessage ="Giá trị sale không được âm")]
        [Remote(
            action:"SalePriceCheck",
            controller: "Product",
            AdditionalFields ="Price")]
        public float SalePrice {  get; set; }
        [Required(ErrorMessage = "Không được để trống mô tả")]
        [MaxLength(1500,ErrorMessage ="Mô tả chỉ được giới hạn ở 1500 từ")]
        [Remote(action:"DescriptionCheck", controller:"Product")]
        public string Description {  get; set; }
        [Remote(action:"CategoryIdCheck",controller:"Product")]
        public int CategoryId { get; set; }
        
        
    }
}
