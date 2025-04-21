using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface ISimplexLiquidationServiceRequestRepository
    {
        SimplexLiquidationServiceRequest GetSimplexLiquidationServiceRequestByUserNameAndAccountNumberAndReference(string UserName, string AccountNumber, string UserType,string MutualReference, bool PartialOrFull);
        bool AddSimplexLiquidationServiceRequest(SimplexLiquidationServiceRequest simplexLiquidationServiceRequest);
    }
}
