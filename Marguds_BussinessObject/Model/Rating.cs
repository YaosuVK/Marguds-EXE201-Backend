using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Rating
    {
        public Guid RatingID { get; set; }
        public int Rate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //
        public Guid ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        //
        public Guid AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Account { get; set; }
    }
}
