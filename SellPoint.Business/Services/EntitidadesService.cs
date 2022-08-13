using Microsoft.EntityFrameworkCore;
using SellPoint.Business.Interfaces;
using SellPoint.Data.Context;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Business.Services
{
    public class EntitidadesService<T> : IEntitidadesRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public EntitidadesService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<String> Login(Entidades entity)
        {
            var foundUser = await context.Entidades.FirstOrDefaultAsync
                (x => x.UserNameEntidad == entity.UserNameEntidad 
                   && x.PassworEntidad == entity.PassworEntidad);

            if (foundUser is not null)
            {
                return $"Bienvenido a SellPoint {foundUser.UserNameEntidad}.";
            }

            return "Este usuario no existe";
        }
    }
}
