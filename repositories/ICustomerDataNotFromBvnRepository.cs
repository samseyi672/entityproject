using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface ICustomerDataNotFromBvnRepository
    {
        IEnumerable<CustomerDataNotFromBvn> GetAllCustomerDataNotFromBvn();
        CustomerDataNotFromBvn GetCustomerDataNotFromBvnByUserName(string userName);
        CustomerDataNotFromBvn GetUserByCustomerDataNotFromBvnPhoneNumber(string PhoneNumber);
        void AddCustomerDataNotFromBvn(CustomerDataNotFromBvn CustomerDataNotFromBvn);
        void UpdateOCustomerDataNotFromBvn(CustomerDataNotFromBvn CustomerDataNotFromBvn);
        void DeleteCustomerDataNotFromBvn(string userName);
        CustomerDataNotFromBvn GetCustomerDataNotFromBvnByUserIdAndUserType(long UserId, string userType);
    }
}
