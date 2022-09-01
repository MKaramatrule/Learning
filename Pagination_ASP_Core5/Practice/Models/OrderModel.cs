using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
    }


    public class OrderPagingViewModel
    {
        ///<summary>
        /// Gets or sets Customers.
        ///</summary>
        public List<OrderModel> Orders { get; set; }

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }
    }
}
