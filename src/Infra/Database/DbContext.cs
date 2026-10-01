using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
};