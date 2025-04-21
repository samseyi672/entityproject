using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IUserCredentialsRepository
    {
        IEnumerable<UserCredentials> GetAllUserCredentials();
        UserCredentials GetUserCredentialsByUcid(int ucid);
        void AddUserCredentials(UserCredentials registration);
        void UpdateUser(UserCredentials registration);
        void DeleteUserCredentials(int ucid);
    }
}
