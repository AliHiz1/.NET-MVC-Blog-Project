using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} gereklidir.")]
        [MinLength(5, ErrorMessage = "{0} 5 karakterden kısa olamaz"), MaxLength(35, ErrorMessage = "{0} 35 karakterden uzun olamaz")]
        [Display(Name = "İsim Soyisim")]
        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        //[Display(Name = "Student Name")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz {0} girdiniz.")]
        [MinLength(12, ErrorMessage = "{0} 12 karakterden kısa olamaz"), MaxLength(50, ErrorMessage = "{0} 50 karakterden uzun olamaz")]
        [Display(Name = "E-mail Adresi")]

        //[DataType(DataType.EmailAddress)]
        //[Required(ErrorMessage = "Please enter Email ID")]
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(225, MinimumLength = 30, ErrorMessage = "{0} 30 karakterden uzun ve 225 karakterden kısa olmalı.")]
        [Display(Name = "Mesaj")]
        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Please enter message"), MaxLength(250)]
        //[Display(Name = "message")]
        public string Mesaj { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "url")]
        public string Url { get; set; }

    }
}