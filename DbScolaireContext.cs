using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2_school_
{
    internal class DbScolaireContext : DbContext
    {
        public DbScolaireContext (): base("ecoleConnect")
        {
        }
        public DbSet <Classe> Classes { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public class DbScolaireContextFactory : IDbContextFactory<DbScolaireContext>
        {
            public DbScolaireContext Create()
            {
                return new DbScolaireContext();
            }
        }

    }
}
