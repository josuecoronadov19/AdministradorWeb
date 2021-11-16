using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministradorWeb.Models;

namespace AdministradorWeb.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }
        public DbSet<AdministradorWeb.Models.Doctores> Doctores { get; set; }



    }
}
