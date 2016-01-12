using NtxBlog.EntityFramework;
using EntityFramework.DynamicFilters;

namespace NtxBlog.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly NtxBlogDbContext _context;

        public InitialDataBuilder(NtxBlogDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
