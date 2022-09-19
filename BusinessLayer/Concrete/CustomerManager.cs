using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public Customer TGetByID(int id)
        {
            return _customerDAL.GetByID(id);
        }

        public List<Customer> IGetList()
        {
            return _customerDAL.GetList();
        }

        public void TDelete(Customer item)
        {

            _customerDAL.Delete(item);
        }

        public void TInsert(Customer item)
        {
            if(item.CustomerSurname.Length<=5 && item.CustomerName.Length<=5 && item.CustomerName.Length >= 20)
            {
                //hata mesajı
            }
            else
            {
                _customerDAL.Insert(item);
            }
            
        }

        public void TUpdate(Customer item)
        {
            _customerDAL.Update(item);
        }

        public List<Customer> TGetListByAntalya()
        {
            return _customerDAL.GetListByAntalya();
        }
    }
}
