using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDAL : GenericRepository<Product>, IProductDAL
    {
        //güncelleme için gereken işlemler
        public void ChangeStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }
    }
}
