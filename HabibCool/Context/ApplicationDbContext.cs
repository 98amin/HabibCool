using HabibCool.Models;
using HabibCool.Models.Agreement;
using HabibCool.Models.CarType;
using Microsoft.EntityFrameworkCore;

namespace HabibCool.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        DbSet<Agreement> Agreements { get; set; }
        DbSet<CarType> CarTypes { get; set; }
        DbSet<ServiceMan> ServiceMen { get; set; }
    }
}
