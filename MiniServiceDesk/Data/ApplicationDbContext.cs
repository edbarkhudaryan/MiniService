using System;
using Microsoft.EntityFrameworkCore;

namespace MiniServiceDesk.Data
{
	public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
        public DbSet<Models.Users> Users { get; set; }
       
	}
}

