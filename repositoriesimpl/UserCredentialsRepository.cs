using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class UserCredentialsRepository : IUserCredentialsRepository
    {
        private readonly AppDbContext _context;

        public UserCredentialsRepository(AppDbContext context) { 
           _context = context;
        }

        public void AddUserCredentials(UserCredentials registration)
        {
           // _context.UserCredentials.Add(registration);
           // _context.SaveChanges();
            var existingUserCredentials = _context.UserCredentials.FirstOrDefault(u => u.Id == registration.Id);
            if (existingUserCredentials != null)
            {
                _context.Entry(existingUserCredentials).CurrentValues.SetValues(registration);
            }
            else
            {
                _context.UserCredentials.Add(registration); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteUserCredentials(int ucid)
        {
            var user = _context.UserCredentials
                .FirstOrDefault(p => p.ucid == ucid);
            if (user != null)
            {
                _context.UserCredentials.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<UserCredentials> GetAllUserCredentials()
        {
            return _context.UserCredentials;
        }

        public UserCredentials GetUserCredentialsByUcid(int ucid)
        {
            return _context.UserCredentials.FirstOrDefault(p => p.ucid == ucid);
        }

        public void UpdateUser(UserCredentials registration)
        {
            _context.UserCredentials.Update(registration);
            _context.SaveChanges();
        }
    }
}
