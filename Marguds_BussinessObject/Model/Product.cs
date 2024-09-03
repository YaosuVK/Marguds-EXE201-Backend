using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int InventoryQuantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public double PurchasePrice { get; set; }

        public double Size { get; set; }

        public Guid CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public Guid BrandID { get; set; }
        [ForeignKey("CategoryID")]
        public Brand Brand { get; set; }

        public Guid AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<ImageProduct> ImageProducts { get; set; }

        public ICollection<CartItem> CartItems { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
