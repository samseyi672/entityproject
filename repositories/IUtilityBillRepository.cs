using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IUtilityBillRepository
    {
        IEnumerable<UtilityBill> GetAllUtilityBill();
        UtilityBill GetUtilityBillByUserNameAndUserType(string userName, string UserType);
        bool AddUtilityBill(UtilityBill UtilityBill);
        void UpdateUtilityBill(Signature UtilityBill);
        bool DeleteUtilityBill(string userName, string UserType);
    }
}
