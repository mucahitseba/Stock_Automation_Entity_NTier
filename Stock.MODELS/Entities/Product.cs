using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.MODELS.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Barcode should only contain numbers.")]
        public string ProductBarcode { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [Required]
        public int PerBoxPiece { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; } = 0;
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new HashSet<SaleDetail>();

        public override string ToString() => $"{ProductName}";
    }
}
