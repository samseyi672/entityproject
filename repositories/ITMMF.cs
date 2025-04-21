using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface ITMMF
    {
        IEnumerable<TMMFDetail> GetAllTMMF();
        TMMFDetail GetTMMFByID(int id);
        void AddTMMF(TMMFDetail tMMFDetail);
        void UpdateTMMF(TMMFDetail tMMFDetail);
        void DeleteTMMF(int id);
    }
}
