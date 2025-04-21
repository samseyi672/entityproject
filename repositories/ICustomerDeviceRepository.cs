using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface ICustomerDeviceRepository
    {
        IEnumerable<CustomerDevice> GetAllCustomerDevice();
        CustomerDevice GetCustomerDeviceByUserName(string userName);
        void AddCustomerDevice(CustomerDevice registration);
        void UpdateCustomerDevice(CustomerDevice registration);
        void DeleteCustomerDevice(string userName);
    }
}
