using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IHistoricalPerformance
    {
        IEnumerable<HistoricalPerformance> GetAllHistoricalPerformance();
        HistoricalPerformance GetHistoricalPerformanceByUserName(string userName);
        void AddHistoricalPerformance(HistoricalPerformance historicalPerformance);
        void UpdateHistoricalPerformance(HistoricalPerformance historicalPerformance);
        void DeleteHistoricalPerformance(int id);
    }
}
