using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCDay1.Models
{
    public class Person
    {
        public  int Id { get; set; }
        //attribute
        [Required]
        [Range(5,85)]
        public int ? Age { get; set; }
        public int Sex { get; set; }
        [Required]
        [StringLength(15,MinimumLength =6)]
        public  string Name { get; set; }
        [CNPhoneNumAttribute]
        public string PhoneNum { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "{0}两次输入的密码必须一致")]
        public string Password2 { get; set; }
        [EmailAddress(ErrorMessage ="{0}请输入正确的Email地址")]
        public string Email { get; set; }
        [QQNumberAtrribute]
        public string QQ { get; set; }
    }
}