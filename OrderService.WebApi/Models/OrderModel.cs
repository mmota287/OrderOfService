using OrderOfService.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderOfService.WebApi.Models
{
    public class OrderModel
    {
        [Required]
        public long OrderId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public virtual List<OrderItem> Itens { get; set; }
    }
}