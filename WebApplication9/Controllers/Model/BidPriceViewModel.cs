﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Controllers.Model
{
    public class BidPriceViewModel
    {
        [Required] 
        public int CompanyId { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
