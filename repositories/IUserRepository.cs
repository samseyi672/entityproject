using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
        Users GetUserByUserName(string userName);
        void AddUser(Users registration);
        void UpdateUser(Users registration);
        void DeleteUser(string userName);
        Users GetUserByUserNameAndUserType(string userName, string userType);
    }
}
