﻿using SiteDeals.MVCWebUI.Enums;
using System.ComponentModel.DataAnnotations;

namespace SiteDeals.MVCWebUI.Models
{

    public class UserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı ismi gerekldir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Doğum tarihi")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        public string? Picture { get; set; }

        [Display(Name = "Şehir")]
        public string? City { get; set; }

        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }
    }

}
