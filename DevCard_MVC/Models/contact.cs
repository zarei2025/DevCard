using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MaxLength(30, ErrorMessage = "حداکثر 30 کاراکتر می توان وارد کرد.")]
        [MinLength(3, ErrorMessage = "حداقل 3 کاراکتر راوارد کنید.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست.")]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Email { get; set; }

        public int Type { get; set; }
        public string Massage { get; set; }

        public SelectList Services { get; set; }
    }
}