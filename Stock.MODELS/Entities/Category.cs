using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.MODELS.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(20)]
        [Required]
        public string CategoryName { get; set; }


        [Required]
        public decimal KDV { get; set; }
        [Required]
        public decimal Avails { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public override string ToString() => $"{CategoryName}";
    }
}
