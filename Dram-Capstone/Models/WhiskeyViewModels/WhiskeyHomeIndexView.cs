using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models.WhiskeyViewModels
{
    public class WhiskeyHomeIndexView
    {
        public Whiskey Whiskey { get; set; }

        public List <Whiskey> FavoriteWhiskeys { get; set; }
        public List <Whiskey> OthersWhiskeys { get; set; }
    }
}
