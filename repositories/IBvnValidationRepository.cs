using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IBvnValidationRepository
    {
        BvnValidation GetBvnValidationByBvn(string Bvn);
        bool AddBvnValidation(BvnValidation bvnValidation);
    }
}
