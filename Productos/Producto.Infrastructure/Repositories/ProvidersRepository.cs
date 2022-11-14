﻿using Microsoft.EntityFrameworkCore;
using Producto.Core.Entities;
using Producto.Core.Interfaces;
using Producto.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.Infrastructure.Repositories
{
    public class ProvidersRepository: BaseRepository<Providers>, IProvidersRepository
    {
        public ProvidersRepository(ProductoApiContext context) : base(context)
        {

        }
        public Task<IEnumerable<Providers>> GetProviders()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Providers>> GetProviderById(int Provider_Id)
        {
            return await _entities.Where(x => x.Id == Provider_Id).ToListAsync();
        }

      
        public Task InsertProvider(Providers providers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProvider(Providers providers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProvider(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Providers> GetProvider(int id)
        {
            throw new NotImplementedException();
        }
    }
}
