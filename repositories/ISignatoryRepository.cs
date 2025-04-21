using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface ISignatoryRepository
    {
        IEnumerable<Signature> GetAllSignature();
        Signature GetSignatureByUserNameAndUserType(string userName, string UserType);
        bool AddSignature(Signature Signature);
        void UpdateSignature(Signature Signature);
        bool DeleteSignature(string userName, string UserType);
    }
}
