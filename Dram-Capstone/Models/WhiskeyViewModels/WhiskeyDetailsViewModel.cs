using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models.WhiskeyViewModels
{
    public class WhiskeyDetailsViewModel
    {
        public Whiskey Whiskey { get; set; }
        public Review Review { get; set; }
        public FragrantFlavor FragrantFlavor { get; set; }
        public FruityFlavor FruityFlavor { get; set; }
        public GrainyFlavor GrainyFlavor { get; set; }
        public GrassyFlavor GrassyFlavor { get; set; }
        public OffNoteFlavor OffNoteFlavor { get; set; }
        public PeatyFlavor PeatyFlavor { get; set; }
        public WineyFlavor WineyFlavor { get; set; }
        public WoodyFlavor WoodyFlavor { get; set; }
            
    }
}
