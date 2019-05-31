using bttTeamCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bttTeamCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Ciclistas.Any())
            {
                return;   // DB has been seeded
            }

            var ciclistas = new Ciclista[]
            {
                new Ciclista {Nome="Vasco Simões", Telemovel="919123434", Mail="vs@vs.pt", DataNascimento=new DateTime(1990,5,10), BI="1356568", Localidade="Tomar"},

            };
            foreach (Ciclista s in ciclistas)
            {
                context.Ciclistas.Add(s);
            }
            context.SaveChanges();

           
     
        }
    }
}
