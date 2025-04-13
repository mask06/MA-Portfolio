using MA_Portfolio.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DAL.Context
{
    public class MADbContext : DbContext
    {
        public MADbContext(DbContextOptions<MADbContext> options) : base(options)
        {}
        public DbSet<About> abouts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Certificate> certificates { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Workshop> workshops { get; set; }
        public DbSet<Information> informations { get; set; }
        public DbSet<Language> languages { get; set; }
    }
}
