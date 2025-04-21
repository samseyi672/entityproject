using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class BvnValidationRepository : IBvnValidationRepository
    {
        private readonly AppDbContext _context;

        public BvnValidationRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool AddBvnValidation(BvnValidation bvnValidation)
        {
            throw new NotImplementedException();
        }

        public BvnValidation GetBvnValidationByBvn(string Bvn)
        {
            var existingBvnValidation = _context.BvnValidations.FirstOrDefault(u => u.BVN.Equals(Bvn,
             StringComparison.CurrentCultureIgnoreCase));
            return existingBvnValidation;
        }
    }
}


























































































































