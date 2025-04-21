using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IRegistrationSessionRepository
    {
        IEnumerable<RegistrationSession> GetAllRegistrationSession();
        void AddRegistrationSession(RegistrationSession RegistrationSession);
        void UpdateRegistrationSession(RegistrationSession RegistrationSession);
        void DeleteRegistrationSessionByUserIdOrRegid(long userorregid);
    }
}
