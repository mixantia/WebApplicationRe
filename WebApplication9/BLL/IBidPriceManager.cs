using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.BLL.Models;

namespace WebApplication9.BLL
{
    interface IBidPriceManager
    {
        IEnumerable<BidPriceDto> Get();
        void Add(BidPriceDto bidPriceDto);

    }
}
