using Nvh_Th2Lab3.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nvh_Th2Lab3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bạn cần nhập vào họ tên")]
        [DisplayName("Họ tên")]
        [StringLength(100, MinimumLength =4, ErrorMessage = "Tên có độ dài từ 4 đến 100 ký tự")]
        public string? Name { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage ="Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@+gmail.com",ErrorMessage ="Email sai định dạng!")]
        public string? Email { get; set; }
        [DisplayName("Mât khẩu")]
        [StringLength(100, MinimumLength = 8,ErrorMessage ="Mật khẩu có độ dài từ 8 đến 100 ký tự")]
        [Required(ErrorMessage = "Bạn cần nhập vào mật khẩu!!")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^A-Za-z0-9]).+$",ErrorMessage ="Mật khẩu phải gồm ít nhất 1 ký tự đặc biệt, chữ cái viết hoa, chữ thường và số")]
        public string? Password { get; set; }
        [Required(ErrorMessage ="Bạn cần chọn ngành học!!")]
        [DisplayName("Ngành học")]
        public Branch? Branch { get; set; }
        [Required(ErrorMessage="Bạn cần chọn giới tính")]
        [DisplayName("Giới tính")]
        public Gender? Gender { get; set; }
        [DisplayName("Hệ học")]
        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Bạn cần nhập vào địa chỉ thường trú!!")]
        [DisplayName("Địa chỉ thường trú")]
        public string? Address { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Bạn chưa nhâpj vào ngày sinh của bạn")]
        [Range(typeof(DateTime),"1/1/1963","31/12/2005",ErrorMessage ="Ngày sinh trong khoảng từ 1/1/1963 đến 31/12/2005")]
        [DisplayName("Ngày sinh")]
        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Ảnh đại diện")]
        public string? Image { get; set; }
        [DisplayName("Điểm")]
        [Required(ErrorMessage ="Bạn cần nhập vào điểm")]
        [Range(0.0,10.0,ErrorMessage ="Điểm nằm trong khoảng từ 0 - 10")]     
        public float? Diem {  get; set; }
        
    }
}
