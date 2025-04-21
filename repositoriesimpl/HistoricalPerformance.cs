using EntityProject.DBContext;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{
    public class HistoricalPerformance : IHistoricalPerformance
    {
        private readonly AppDbContext _context;

        public HistoricalPerformance(AppDbContext context)
        {
            _context = context;
        }

        public void AddHistoricalPerformance(entities.HistoricalPerformance historicalPerformance)
        {
            var existingHistoricalPerformance = _context.HistoricalPerformances.FirstOrDefault(u => u.Id == historicalPerformance.Id);
            if (existingHistoricalPerformance != null)
            {
                _context.Entry(existingHistoricalPerformance).CurrentValues.SetValues(historicalPerformance);
            }
            else
            {
                _context.HistoricalPerformances.Add(historicalPerformance); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteHistoricalPerformance(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entities.HistoricalPerformance> GetAllHistoricalPerformance()
        {
            return _context.HistoricalPerformances;
        }

        public entities.HistoricalPerformance GetHistoricalPerformanceByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public void UpdateHistoricalPerformance(entities.HistoricalPerformance historicalPerformance)
        {
            throw new NotImplementedException();
        }
    }
}




































































































