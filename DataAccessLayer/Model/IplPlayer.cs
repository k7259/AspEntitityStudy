using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class IplPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
       // public string Team { get; set; }
       public Guid TeamId { get; set; }
        public IplTeam Team { get; set; }   

    }
}
