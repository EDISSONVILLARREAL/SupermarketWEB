using Microsoft.EntityFrameworkCore;
namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }

        protected SupermarketContext()
        {
        }
    }
}
