
using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class RegistrationRepository : IRegistrationRepository
    {

       private readonly AppDbContext _context;    
        public RegistrationRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public void AddRegistration(Registration registration)
        {
            //_context.Registration.Add(registration);
           // _context.SaveChanges();
            var existingRegistration = _context.Registration.FirstOrDefault(u => u.Id == registration.Id);
            if (existingRegistration != null)
            {
                _context.Entry(existingRegistration).CurrentValues.SetValues(registration);
            }
            else
            {
                _context.Registration.Add(registration); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteRegistration(string userName)
        {
            var user = _context.Registration
                .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.Registration.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Registration> GetAllRegistration()
        {
            return _context.Registration;
        }

        public Registration GetRegistrationByUserName(string userName)
        {
            return _context.Registration
                .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase));
        }

        public Registration GetRegistrationByBvnAndUserType(string bvn, string UserType)
        {
            return _context.Registration
                .FirstOrDefault(p => string.Equals(p.Bvn,bvn, StringComparison.CurrentCultureIgnoreCase)
                && string.Equals(p.UserType,UserType, StringComparison.CurrentCultureIgnoreCase));
        }

        public void UpdateRegistration(Registration registration)
        {
            _context.Registration.Update(registration);
            _context.SaveChanges();
        }

        public Registration GetRegistrationByUserNameAndUserType(string userName, string userType)
        {
            return _context.Registration
              .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
               && string.Equals(p.UserType,userType,StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
















































