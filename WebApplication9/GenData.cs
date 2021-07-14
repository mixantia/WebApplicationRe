using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.DataAccess;
using WebApplication9.DataAccess.Model;
using WebApplication9.Models;

namespace WebApplication9
{
    public class GenData
    {
        public static void InitData(DataProvider context)
        {
            for (int i = 0; i < 10; i++)
            {
                if (!context.Companies.Any())
                    context.Companies.Add(new Company(){Name = "Company "+i});
            }
        }
    }
}
