namespace Web.Data.Persistence
{
    using Microsoft.EntityFrameworkCore;

    public class Context : DbContext
    {
        public Context() : base()
        { }

        public Context(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}