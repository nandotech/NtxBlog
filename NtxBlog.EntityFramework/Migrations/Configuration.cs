using System.Data.Entity.Migrations;
using NtxBlog.Migrations.SeedData;

namespace NtxBlog.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<NtxBlog.EntityFramework.NtxBlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NtxBlog";
        }

        protected override void Seed(NtxBlog.EntityFramework.NtxBlogDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
