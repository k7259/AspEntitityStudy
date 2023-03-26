using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<IplPlayer> IplPlayers { get; set; }
        public DbSet<IplTeam> IplTeams { get; set; }
        public string connectionstring;
            
        public ApplicationDbContext()

        {

 connectionstring =
            "Data Source=DESKTOP-3N1B328;Initial Catalog=IplDb;Integrated Security=True;  TrustServerCertificate=True;";
    }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(connectionstring);
    }

}
