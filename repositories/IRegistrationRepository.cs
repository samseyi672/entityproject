using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IRegistrationRepository
    {
        IEnumerable<Registration> GetAllRegistration();

        Registration GetRegistrationByBvnAndUserType(string bvn,string UserType);
        Registration GetRegistrationByUserName(string userName);
        void AddRegistration(Registration registration);
        void UpdateRegistration(Registration registration);
        void DeleteRegistration(string userName);
        Registration GetRegistrationByUserNameAndUserType(string userName, string userType);
    }
}















































































































