using SellPoint.Business.Interfaces;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Business.Services
{
    public class EntidadesRepository : IvalidationService
    {
        public Task<Entidades> CustomValidation(Entidades entity)
        {
            throw new NotImplementedException();
        }
    }
}
