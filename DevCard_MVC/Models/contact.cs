using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MaxLength(30, ErrorMessage = "حداکثر 30 کاراکتر می توان وارد کرد")]
        [MinLength(3,ErrorMessage = "تعداد کاراکتر های وارد شده نباید کمتر از 3 کاراکتر باشد.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست.")]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Email { get; set; }
        public string Type { get; set; }
        public string Massage { get; set; }
    }
}