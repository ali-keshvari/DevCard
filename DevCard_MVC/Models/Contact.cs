using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول باید 3 باشد")]
        [MaxLength(100,ErrorMessage = "حداکثر طول باید 100 باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مقدار ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }
    }
}
