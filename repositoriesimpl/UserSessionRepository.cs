using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class UserSessionRepository : IUserSessionRepository
    {
        private readonly AppDbContext _context;

        public UserSessionRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddUserSession(UserSession registration)
        {
            //_context.UserSession.Add(registration);
            //_context.SaveChanges();
            var existingUserSession = _context.UserSession.FirstOrDefault(u => u.Id == registration.Id);
            if (existingUserSession != null)
            {
                _context.Entry(existingUserSession).CurrentValues.SetValues(registration);
            }
            else
            {
                _context.UserSession.Add(registration); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteUserSession(int ucid)
        {
            var user = _context.UserSession
               .FirstOrDefault(p => p.ucid == ucid);
            if (user != null)
            {
                _context.UserSession.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<UserSession> GetAllUserSession()
        {
            return _context.UserSession;
        }

        public UserSession GetUserSessionByUcid(int ucid)
        {
            return _context.UserSession.FirstOrDefault(p => p.ucid == ucid);
        }

        public void UpdateUserSession(UserSession registration)
        {
            _context.UserSession.Update(registration);
            _context.SaveChanges();
        }
    }
}
