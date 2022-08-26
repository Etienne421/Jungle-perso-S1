using Microsoft.EntityFrameworkCore;

namespace Jungle_DataAccess.Data
{
    public class JungleDbContext : DbContext
    {
        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
        {

        }


    }
}
