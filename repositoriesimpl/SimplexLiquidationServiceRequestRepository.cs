using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityProject.repositoriesimpl
{

    public class SimplexLiquidationServiceRequestRepository : ISimplexLiquidationServiceRequestRepository
    {
        private readonly AppDbContext _context;

        public SimplexLiquidationServiceRequestRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool AddSimplexLiquidationServiceRequest(SimplexLiquidationServiceRequest simplexLiquidationServiceRequest)
        {
            var existingClientBank = _context.SimplexLiquidationServiceRequest.FirstOrDefault(u => u.InvestmentId.Equals(simplexLiquidationServiceRequest.InvestmentId,
                StringComparison.CurrentCultureIgnoreCase) && u.RedemptionAccount == simplexLiquidationServiceRequest.RedemptionAccount && u.UserName.Equals(simplexLiquidationServiceRequest.UserName,
                StringComparison.CurrentCultureIgnoreCase) && u.UserType.Equals(simplexLiquidationServiceRequest.UserType, StringComparison.CurrentCultureIgnoreCase));
            if (existingClientBank != null)
            {
                _context.Entry(existingClientBank).CurrentValues.SetValues(simplexLiquidationServiceRequest);
                _context.SaveChanges();
                return true;
            }
            else
            {
                _context.SimplexLiquidationServiceRequest.Add(simplexLiquidationServiceRequest); // new entities
            }
            _context.SaveChanges();
            return false;
        }

        public SimplexLiquidationServiceRequest GetSimplexLiquidationServiceRequestByUserNameAndAccountNumberAndReference(string UserName, string AccountNumber, string UserType, string MutualReference,bool PartialOrFull)
        {
            var existingSimplexLiquidationServiceRequest = _context.SimplexLiquidationServiceRequest.FirstOrDefault(u => u.RedemptionAccount.Equals(AccountNumber,
             StringComparison.CurrentCultureIgnoreCase) && u.UserName.Equals(UserName,
             StringComparison.CurrentCultureIgnoreCase)
             && u.UserType.Equals(UserType,
             StringComparison.CurrentCultureIgnoreCase) && u.InvestmentId.Equals(MutualReference,StringComparison.CurrentCultureIgnoreCase)
             &&u.PartialOrFull==PartialOrFull);
            return existingSimplexLiquidationServiceRequest;
        }
    }
}
