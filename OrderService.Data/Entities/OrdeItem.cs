using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOfService.Data.Entities
{
    [Table("OrderItem")]
    public partial class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public long OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
