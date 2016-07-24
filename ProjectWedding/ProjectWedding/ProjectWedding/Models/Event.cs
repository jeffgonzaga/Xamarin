using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWedding.Models
{
    public class Event:Tile
    {
        public DateTimeOffset EventDate { get; private set; }
    }
}
