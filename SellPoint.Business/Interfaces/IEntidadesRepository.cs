using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Business.Interfaces
{
    public  interface IvalidationService
    {
        Task<Entidades> CustomValidation(Entidades entity);
    }
}
