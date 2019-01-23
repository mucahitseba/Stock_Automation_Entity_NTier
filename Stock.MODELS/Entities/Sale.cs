using Stock.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.MODELS.Entities
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime SaleTime { get; set; } = DateTime.Now;
        public PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new HashSet<SaleDetail>();
    }
}
