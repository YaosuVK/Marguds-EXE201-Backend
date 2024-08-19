using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Marguds_BussinessObject.Model
{
    public class Account
    {
        [Key]
        public string AccountID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Role { get; set; }
        public string? Image { get; set; }
        
        [Required]
        public string Status { get; set; }
        public DateTime DateOfBirth { get; set; }

        //public ICollection<CartItem> CartItems { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
