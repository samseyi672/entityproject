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
    public class UtilityBillRepository : IUtilityBillRepository
    {

        private readonly AppDbContext _context;

        public UtilityBillRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool AddUtilityBill(UtilityBill UtilityBill)
        {
            var existingUtilityBill = _context.UtilityBill.FirstOrDefault(u => u.UserName.Equals(UtilityBill.UserName,
            StringComparison.CurrentCultureIgnoreCase) &&
            u.UserType.Equals(UtilityBill.UserType, StringComparison.CurrentCultureIgnoreCase));
            if (existingUtilityBill != null)
            {
                _context.Entry(existingUtilityBill).CurrentValues.SetValues(UtilityBill);
                return true;
            }
            else
            {
                _context.UtilityBill.Add(UtilityBill); // new entities
            }
            _context.SaveChanges();
            return false;
        }

        public bool DeleteUtilityBill(string userName, string UserType)
        {
            var user = _context.UtilityBill
                   .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(p.UserType, UserType, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                _context.UtilityBill.Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<UtilityBill> GetAllUtilityBill()
        {
           return _context.UtilityBill; 
        }

        public UtilityBill GetUtilityBillByUserNameAndUserType(string userName, string UserType)
        {
            var user = _context.UtilityBill
               .FirstOrDefault(p => string.Equals(p.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                && string.Equals(p.UserType, UserType, StringComparison.CurrentCultureIgnoreCase));
            if (user != null)
            {
                return user;
            }
            return user;
        }

        public void UpdateUtilityBill(Signature UtilityBill)
        {
            throw new NotImplementedException();
        }
    }
}

















