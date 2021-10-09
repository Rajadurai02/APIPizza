using System;
using System.Collections.Generic;

#nullable disable

namespace OrderItemDetailsAPI.Models
{
    public partial class OrderItemDetail
    {
        public int ItemId { get; set; }
        public int ToppingId { get; set; }

        public virtual OrderDetail Item { get; set; }
    }
}
