using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.DataAccess.Model;
using WebApplication9.DataAccess.Models;

namespace WebApplication9.DataAccess
{
    public class DataProvider : IDataProvider
    {
        public List<Company> Companies { get; set; }
        public List<BidPrice> BidPrices { get; set; }
    }

    public interface IDataProvider
    {
        
    }
}
