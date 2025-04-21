using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using Retailbanking.Common.DbObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class CustomerDataNotFromBvnRepository : ICustomerDataNotFromBvnRepository
    {
        private readonly AppDbContext _context;

        public CustomerDataNotFromBvnRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomerDataNotFromBvn(CustomerDataNotFromBvn CustomerDataNotFromBvn)
        {
           // _context.CustomerDataNotFromBvn.Add(CustomerDataNotFromBvn);
           // _context.SaveChanges();
            var existingCustomerDataNotFromBvn = _context.MobileDevice.FirstOrDefault(u => u.id == CustomerDataNotFromBvn.Id);
            if (existingCustomerDataNotFromBvn != null)
            {
                _context.Entry(existingCustomerDataNotFromBvn).CurrentValues.SetValues(CustomerDataNotFromBvn);
            }
            else
            {
                _context.CustomerDataNotFromBvn.Add(CustomerDataNotFromBvn); // new entities
            }
            _context.SaveChanges();
        }

        public CustomerDataNotFromBvn GetUserByCustomerDataNotFromBvnPhoneNumber(string PhoneNumber)
        {
            return _context.CustomerDataNotFromBvn
                .FirstOrDefault(p => string.Equals(p.PhoneNumber, PhoneNumber, StringComparison.CurrentCultureIgnoreCase));
        }

        public void DeleteCustomerDataNotFromBvn(string userName)
        {
            var user = _context.CustomerDataNotFromBvn
              .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.CustomerDataNotFromBvn.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CustomerDataNotFromBvn> GetAllCustomerDataNotFromBvn()
        {
            return _context.CustomerDataNotFromBvn;
        }

        public CustomerDataNotFromBvn GetCustomerDataNotFromBvnByUserName(string userName)
        {
            return _context.CustomerDataNotFromBvn.FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
        }

        public void UpdateOCustomerDataNotFromBvn(CustomerDataNotFromBvn CustomerDataNotFromBvn)
        {
            _context.CustomerDataNotFromBvn.Update(CustomerDataNotFromBvn);
            _context.SaveChanges();
        }

        public CustomerDataNotFromBvn GetCustomerDataNotFromBvnByUserIdAndUserType(long UserId, string userType)
        {
            return _context.CustomerDataNotFromBvn.FirstOrDefault(p => p.UserId==UserId && string.Equals(p.UserType,userType,StringComparison.CurrentCultureIgnoreCase));
        }
    }
}




























































