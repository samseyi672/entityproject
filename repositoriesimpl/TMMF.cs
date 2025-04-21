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
    public class TMMF : ITMMF
    {

        private readonly AppDbContext _context;

        public TMMF(AppDbContext context)
        {
            _context = context;
        }

        public void AddTMMF(TMMFDetail tMMFDetail)
        {
            var existingTMMFDetail = _context.TMMFDetails.FirstOrDefault(u => u.Id == tMMFDetail.Id);
            if (existingTMMFDetail != null)
            {
                _context.Entry(existingTMMFDetail).CurrentValues.SetValues(existingTMMFDetail);
            }
            else
            {
                _context.TMMFDetails.Add(existingTMMFDetail); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteTMMF(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TMMFDetail> GetAllTMMF()
        {

            return _context.TMMFDetails;
        }

        public TMMFDetail GetTMMFByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTMMF(TMMFDetail tMMFDetail)
        {
            throw new NotImplementedException();
        }
    }
}
