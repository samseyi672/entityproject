using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(Users registration)
        {
            // _context.Users.Add(registration);
            // _context.SaveChanges();
            var existingUser = _context.Users.FirstOrDefault(u => u.id == registration.id); 
            if (existingUser != null)
            {
                _context.Entry(existingUser).CurrentValues.SetValues(registration);
            }
            else
            {
                _context.Users.Add(registration); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteUser(string userName)
        {
            var user = _context.Users
                .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return _context.Users;
        }

        public Users GetUserByUserName(string userName)
        {
            return _context.Users
                .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
        }

        public Users GetUserByUserNameAndUserType(string userName, string userType)
        {
            return _context.Users
                   .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                     && string.Equals(p.UserType,userType, StringComparison.CurrentCultureIgnoreCase));
        }

        public void UpdateUser(Users registration)
        {
            _context.Users.Update(registration);
            _context.SaveChanges();
        }
    }
}






