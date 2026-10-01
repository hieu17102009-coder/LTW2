using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCLab05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name ="Ho va ten"),
            Required(ErrorMessage ="Ho ten khong duoc de trong"),
            MinLength(6, ErrorMessage ="Do dai ho ten phai lon hon 6"),
            MaxLength(20, ErrorMessage ="Do dai ho ten chi duoc chua it hon 20 ky tu"),
        ]
        public string FullName { get; set; }
        [Display(Name ="Dia chi email")]
        [Required(ErrorMessage ="Dia chi email khong duoc de trong")]
        [EmailAddress(ErrorMessage ="Dia chi email khong dung dinh dang")]
        public string Email {  get; set; }
        [Display(Name ="So dien thoai")]
        [Required(ErrorMessage ="So dien thoai khong duoc de trong!")]
        [Remote(action:"VerifyPhone",controller:"Account")]
        public string Phone { get; set; }
        [Display(Name ="Dia chi")]
        [Required(ErrorMessage ="DIa chi khong duoc de trong")]
        [Length(6,35,ErrorMessage ="Dia chi co do dai tu 6 den 35 ky tu")]
        public string Address { get; set; }
        [Display(Name ="Anh dai dien")]
        public string Avartar { get; set; }
        [Display(Name ="Ngay sinh")]
        [Required(ErrorMessage ="Ngay sinh khong duoc de trong")]
        [DataType(DataType.Date)]
        public DateTime Birthday {  get; set; }
        [Display(Name ="Gioi tinh")]
        public string Gender { get; set; }
        [Display(Name ="Mat khau")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Link Facebook")]
        [Url(ErrorMessage ="Duong link phai co http hoawc https, vi du: https://facebook.com")]
        public string Facebook { get; set; }

    }
}
