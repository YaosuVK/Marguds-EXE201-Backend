﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class ImageProduct
    {
        [Key]
        public Guid ImageProductsID { get; set; }
        [Required]
        public string Image { get; set; }
        //
        public Guid ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Products { get; set; }
    }
}
