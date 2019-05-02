using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models.ReviewViewModels
{
    public class ReviewCreateViewModel
    {


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


