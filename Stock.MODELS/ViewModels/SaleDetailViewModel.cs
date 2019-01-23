using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.MODELS.ViewModels
{
    public class SaleDetailViewModel
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal SalePrice { get; set; }
        public decimal KDV { get; set; }
        public decimal Discount { get; set; }
        public int Piece { get; set; }
        public override string ToString()
        {
            string ProductNameString = ProductName;
            if (ProductName.Length > 30)
                ProductNameString = ProductName.Substring(0, 27) + "...";
            else
            {
                for (int i = 0; i < 30-ProductName.Length; i++)
                {
                    ProductNameString += "";
                }
            }
            return $"{ProductNameString,-30} * {Piece,-6} % {KDV,-6} {Total():c2} ";
        }

        public decimal Total()
        {
            return Piece * SalePrice;
        }
    }
}
