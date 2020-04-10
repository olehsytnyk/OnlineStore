using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "Name length of at least 25 characters")]
        public string name { get; set; }

        [Display(Name = "Second name")]
        [StringLength(15)]
        [Required(ErrorMessage = "Name length of at least 15 characters")]
        public string surname { get; set; }

        [Display(Name = "Addres")]
        [StringLength(20)]
        [Required(ErrorMessage = "Address length of at least 20 characters")]
        public string addres { get; set; }

        [Display(Name = "Phone number")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number length of at least 15 characters")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Email length of at least 30 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
