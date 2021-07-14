using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.DataAccess;
using WebApplication9.DataAccess.Model;
using WebApplication9.DataAccess.Models;

namespace WebApplication9.Models
{
    public class ModelContext : DataProvider
    {
        public List<BidPrice> Bids { get; set; }
        public List<Company> Companies { get; set; }
    }
}
