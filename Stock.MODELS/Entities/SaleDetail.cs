using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.MODELS.Entities
{
    [Table("SaleDetails")]
    public class SaleDetail
    {
        [Key]
        [Column(Order = 1)]
        public int SaleId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        [Required]
        public int Piece { get; set; }
        public decimal SalePrice { get; set; }
        [ForeignKey("SaleId")]
        public virtual Sale Sale { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
