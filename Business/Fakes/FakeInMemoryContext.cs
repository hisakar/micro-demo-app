using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Business.Fakes
{
    public sealed class FakeInMemoryContext : ProjectDbContext
    {
        public FakeInMemoryContext(DbContextOptions<FakeInMemoryContext> options, IConfiguration configuration)
            : base(options, configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(
                    optionsBuilder.UseInMemoryDatabase("FakeDemoDb"));
            }
        }
    }

}

