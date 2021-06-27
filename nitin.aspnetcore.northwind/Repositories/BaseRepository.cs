using nitin.aspnetcore.northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nitin.aspnetcore.northwind.Repositories
{
    public class BaseRepository<T> where T: class
    {
        NorthwindContext _context;
        public BaseRepository(NorthwindContext northwindContext)
        {
            _context = northwindContext;
        }
    }
}
