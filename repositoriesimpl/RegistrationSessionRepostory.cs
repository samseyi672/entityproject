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
    public class RegistrationSessionRepostory : IRegistrationSessionRepository
    {

        private readonly AppDbContext _context;

        public RegistrationSessionRepostory(AppDbContext context)
        {
            _context = context;
        }

        public void AddRegistrationSession(RegistrationSession RegistrationSession)
        {
            //_context.RegistrationSession.Add(RegistrationSession);
            //_context.SaveChanges();
            var existingRegistrationSession = _context.RegistrationSession.FirstOrDefault(u => u.Id == RegistrationSession.Id);
            if (existingRegistrationSession != null)
            {
                _context.Entry(existingRegistrationSession).CurrentValues.SetValues(RegistrationSession);
            }
            else
            {
                _context.RegistrationSession.Add(RegistrationSession); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteRegistrationSessionByUserIdOrRegid(long useridorregeid)
        {
            var user = _context.RegistrationSession
              .FirstOrDefault(p => p.UserId == useridorregeid);
            if (user != null)
            {
                _context.RegistrationSession.Remove(user);
                _context.SaveChanges();
            }
            else {
                var user1 = _context.RegistrationSession
                  .FirstOrDefault(p => p.RegId == useridorregeid);
                _context.RegistrationSession.Remove(user1);
                _context.SaveChanges();
            }
        }

        public IEnumerable<RegistrationSession> GetAllRegistrationSession()
        {
            throw new NotImplementedException();
        }

        public void UpdateRegistrationSession(RegistrationSession RegistrationSession)
        {
            _context.RegistrationSession.Update(RegistrationSession);
            _context.SaveChanges();
        }
    }
}
