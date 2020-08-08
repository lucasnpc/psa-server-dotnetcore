using Microsoft.EntityFrameworkCore;

namespace psa_server_dotnetcore.Model
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        { 

        }
        public DbSet<UserData> users { get; set; }
    }
}
