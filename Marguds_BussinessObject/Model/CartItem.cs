using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class CartItem
    {
        [Key]
        public Guid CartItemID { get; set; }
        public int Quantity { get; set; }
        //
        public Guid ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        //
        public Guid CartID { get; set; }
        [ForeignKey("CartID")]
        public Cart Cart { get; set; }
    }
}
