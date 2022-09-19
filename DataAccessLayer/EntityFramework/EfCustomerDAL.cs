using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        public List<Customer> GetListByAntalya()
        {
            Context c = new Context();
            return c.Customers.Where(x=>x.CustomerCity=="Antalya").ToList();
        }
    }
}
