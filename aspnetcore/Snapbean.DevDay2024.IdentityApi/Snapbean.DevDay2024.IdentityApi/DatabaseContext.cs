using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Snapbean.DevDay2024.IdentityApi;

public class DatabaseContext(DbContextOptions<DatabaseContext> options): IdentityDbContext<UserEntity>(options);

