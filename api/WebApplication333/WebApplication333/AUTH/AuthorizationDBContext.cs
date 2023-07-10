
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace authentication.AUTH
{
    public class AuthorizationDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthorizationDbContext(DbContextOptions<AuthorizationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}