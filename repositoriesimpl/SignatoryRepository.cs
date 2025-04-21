using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class SignatoryRepository : ISignatoryRepository
    {

        private readonly AppDbContext _context;

        public SignatoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool AddSignature(Signature Signature)
        {
            var existingSignature = _context.Signature.FirstOrDefault(u => u.UserName.Equals(Signature.UserName,
             StringComparison.CurrentCultureIgnoreCase) &&
             u.UserType.Equals(Signature.UserType, StringComparison.CurrentCultureIgnoreCase));
            if (existingSignature != null)
            {
                _context.Entry(existingSignature).CurrentValues.SetValues(Signature);
                return true;
            }
            else
            {
                _context.Signature.Add(Signature); // new entities
            }
            _context.SaveChanges();
            return false;
        }

        public bool DeleteSignature(string userName, string UserType)
        {
            var user = _context.Signature
               .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                && string.Equals(p.UserType, UserType, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.Signature.Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Signature> GetAllSignature()
        {
            return _context.Signature;
        }

        public Signature GetSignatureByUserNameAndUserType(string userName, string UserType)
        {
            var user = _context.Signature
               .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                && string.Equals(p.UserType, UserType, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                return user;
            }
            return user;
        }

        public void UpdateSignature(Signature Signature)
        {
            throw new NotImplementedException();
        }
    }
}
















































































