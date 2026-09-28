using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NVHLesson07.Models

{
    public class NVHMember
    {
        public string? Id { get; set; }
        [DisplayName("Tai khoan")]
        [Required(ErrorMessage = "Tai khoan khong duoc de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tai khoan co do dai tu 3 den 20 ky tu")]
        public string NvhName { get; set; }
        [DisplayName("Mat khau")]
        [Required(ErrorMessage = "Ban chua nhap mat khau")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mat khau co do dai tu 8 den 100 ky tu")]
        public string NvhPassword { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Ban chua nhap Email")]
        [DataType(DataType.EmailAddress)]
        public string NvhEmail { get; set; }
        [DisplayName("Dien thoai")]
        [Required(ErrorMessage = "Ban chua nhap so dien thoai")]
        [RegularExpression(@"^0\d{9,9}", ErrorMessage = "Dien thoai gom 10 so va bat dau bang so 0")]
        public string NvhPhone { get; set; }
        
    }
}
