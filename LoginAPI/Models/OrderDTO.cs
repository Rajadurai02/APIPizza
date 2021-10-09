﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    public class OrderDTO
    {
        public int OrderID { get; set; }

        public int OrderTotal { get; set; }

        public int DeliveryCharge { get; set; }

        public string Status { get; set; }

        public string jwtToken { get; set; }
    }
}
