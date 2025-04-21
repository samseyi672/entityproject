using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IClientBankRepository
    {
        IEnumerable<ClientBank> GetAllClientBank();
        ClientBank GetClientBankByUserNameAndBankIdAndAccountNumber(string userName,string BankId,string AccountNumber,string UserType);
        ClientBank GetClientBankByUserNameAndBankId(string userName, string BankId, string UserType);
        bool AddClientBank(ClientBank clientBank);
        void UpdateClientBank(ClientBank clientBank);
        bool DeleteClientBankByUserNameAndBankIdAndAccountNumber(string userName, string BankId, string AccountNumber,string UserType);
    }
}
