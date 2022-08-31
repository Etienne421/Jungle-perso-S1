
using Jungle_DataAccess.Repository.IRepository;
using Jungle_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JungleDbContext _db;

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
