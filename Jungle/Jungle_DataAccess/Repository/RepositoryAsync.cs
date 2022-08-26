using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Jungle_DataAccess.Repository
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        // pour accéder à la BD, aux entités
        private readonly JungleDbContext _db;
        // pour faire des changements directs
        internal DbSet<T> dbset;

        public RepositoryAsync(JungleDbContext db)
        {
            _db = db;
            this.dbset = _db.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await dbset.AddAsync(entity);
        }


    }
}
