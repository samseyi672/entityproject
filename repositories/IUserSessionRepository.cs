using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IUserSessionRepository
    {
        IEnumerable<UserSession> GetAllUserSession();
        UserSession GetUserSessionByUcid(int ucid);
        void AddUserSession(UserSession registration);
        void UpdateUserSession(UserSession registration);
        void DeleteUserSession(int ucid);
    }
}
