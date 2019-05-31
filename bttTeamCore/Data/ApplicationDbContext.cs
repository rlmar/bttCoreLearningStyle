using System;
using System.Collections.Generic;
using System.Text;
using bttTeamCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bttTeamCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ciclista> Ciclistas { get; set; }

        public DbSet<Equipa> Equipas { get; set; }

        public DbSet<Foto> Fotos { get; set; }

        public DbSet<Prova> Provas { get; set; }

        public DbSet<ProvaCiclEquipa> provaCiclEquipas { get; set; }



    }
}
