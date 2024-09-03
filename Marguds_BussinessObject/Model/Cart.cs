using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Cart
    {
        [Key]
        public Guid CartID { get; set; }

        public Guid AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Accounts { get; set; }
        
        public ICollection<CartItem> CartItem { get; set; } = new List<CartItem>();
    }
}
