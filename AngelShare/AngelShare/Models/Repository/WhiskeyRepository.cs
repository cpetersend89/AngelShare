using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelShare.Models.Repository
{
    public class WhiskeyRepository : Repository<Whiskey>
    {
        public List<Whiskey> GetByName(string name)
        {
            return DbSet.Where(a => a.ProductName.Contains(name)).ToList();
        }

        
    }
}
