using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication9.BLL.Models;
using WebApplication9.DataAccess;

namespace WebApplication9.BLL
{
    public class BidPriceManager : IBidPriceManager
    {
        private IDataProvider _dataProvider;
        private IMapper _mapper;
        public IEnumerable<BidPriceDto> Get()
        {
            throw new NotImplementedException();
        }

        public void Add(BidPriceDto bidPriceDto)
        {
            throw new NotImplementedException();
        }
    }
}
