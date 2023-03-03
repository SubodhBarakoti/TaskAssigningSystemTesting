using Microsoft.EntityFrameworkCore;
using TaskAssigningSystem.Models;

namespace TaskAssigningSystem.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }


    }
}
