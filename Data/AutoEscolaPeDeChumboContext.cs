using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Pages.Alunos;
using AutoEscolaPeDeChumbo.Pages.Funcionarios;

namespace AutoEscolaPeDeChumbo.Data
{
    public class AutoEscolaPeDeChumboContext : DbContext
    {
        public AutoEscolaPeDeChumboContext (DbContextOptions<AutoEscolaPeDeChumboContext> options)
            : base(options)
        {
        }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Alunos.Aluno> Aluno { get; set; }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-EFOV76KH;
             Initial Catalog=BDAutoEFirst;Integrated Security=true");
        }
    }
}
