﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailID { get; set; }
        public int Quantity { get; set; }
        public double unitPrice { get; set; }
        public double promotionPrice { get; set; }
        public double TotalAmount { get; set; }

        //public int OrderID { get; set; }
        //[ForeignKey("OrderID ")]
        public Order? Order { get; set; }

        public Guid ProductID { get; set; }
        [ForeignKey("ProductID ")]
        public Product Products { get; set; }
    }
}
