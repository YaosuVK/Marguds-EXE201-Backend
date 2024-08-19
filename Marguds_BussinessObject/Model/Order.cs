using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
        [EnumDataType(typeof(OrderStatus))]
        public OrderStatus Status { get; set; }
        public double Total { get; set; }

        public int? ReportID { get; set; }
        public string AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        public Fees Fees { get; set; }
        public int FeesID { get; set; }
        [ForeignKey("FeesID")]

        public string? transactionID { get; set; }

        [EnumDataType(typeof(PaymentMethod))]
        public PaymentMethod PaymentMethod { get; set; }
        //
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Transaction? Transaction { get; set; }

        public Report? Report { get; set; }
    }

    public enum PaymentMethod
    {
        Cod = 0,
        VnPay = 1
    }

    public enum OrderStatus
    {
        ToPay = 0,
        ToConfirm = 1,
        ToReceive = 2,
        Completed = 3,
        Cancelled = 4,
        ReturnRefund = 5,
        RequestReturn = 6
    }
}
