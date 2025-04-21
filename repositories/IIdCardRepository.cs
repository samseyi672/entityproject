using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IIdCardRepository
    {
        IEnumerable<IdCard> GetAllIdCard();
        IdCard GetIdCardByUserNameAndUserType(string userName, string UserType);
        bool AddIdCard(IdCard IdCard);
        void UpdateIdCard(IdCard IdCard);
        bool DeleteIdCard(string userName, string UserType);
    }
}
