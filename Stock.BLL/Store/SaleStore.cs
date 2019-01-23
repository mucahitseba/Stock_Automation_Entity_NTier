using Stock.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BLL.Store
{
    public class SaleStore:StoreBase<Sale,int>
    {
        public DateTime SaleTime()
        {
            Random rnd = new Random();
            DateTime history = new DateTime(2016, 1, 1);
            int difference = (DateTime.Today - history).Days;
            return history.AddDays(rnd.Next(difference));
        }

    }
}
