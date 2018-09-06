using OrderOfService.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOfService.Data.Entities
{
    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderId { get; set; }

        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateEnded { get; set; }

        public OrderStatus Status { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
