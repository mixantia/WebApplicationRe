using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.BLL.Models;
using WebApplication9.DataAccess.Models;

namespace WebApplication9
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<BidPriceDto, BidPrice>().ReverseMap();
        }
    }
}
