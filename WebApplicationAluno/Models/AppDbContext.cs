using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAluno.Models {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) {

        }
        public DbSet<Aluno> Alunos { get; set; }
       
    }
}
