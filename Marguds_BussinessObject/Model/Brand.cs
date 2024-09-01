using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Brand
    {
        [Key]
        public Guid BrandID { get; set; }
        [Required]
        public string Name { get; set; }
        //
        public ICollection<Product> Products { get; set; }
    }
}
