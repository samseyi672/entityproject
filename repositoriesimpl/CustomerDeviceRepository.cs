using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class CustomerDeviceRepository : ICustomerDeviceRepository
    {
        private readonly AppDbContext _context;

        public CustomerDeviceRepository(AppDbContext context) {
            _context = context;
        }
        public void AddCustomerDevice(CustomerDevice registration)
        {
            _context.CustomerDevice.Add(registration);
            _context.SaveChanges();
        }

        public void DeleteCustomerDevice(string userName)
        {
            var user = _context.CustomerDevice
               .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.CustomerDevice.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CustomerDevice> GetAllCustomerDevice()
        {
            return _context.CustomerDevice;
        }

        public CustomerDevice GetCustomerDeviceByUserName(string userName)
        {
            return _context.CustomerDevice
                 .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
        }

        public void UpdateCustomerDevice(CustomerDevice registration)
        {
            _context.CustomerDevice.Update(registration);
            _context.SaveChanges();
        }
    }
}




