using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class IplTeam
    {
        public Guid Id { get; set; }
            public string Name { get; set; }
        List<IplPlayer> Players { get; }=new List<IplPlayer>();

    }
}
