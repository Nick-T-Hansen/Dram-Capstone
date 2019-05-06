using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models.WhiskeyViewModels
{
    public class WhiskeyEditViewModel
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

        public int whiskeyId { get; set; }

        //need access to the dropdown options
        public List<SelectListItem> FragrantFlavors { get; set; }
        public List<SelectListItem> FruityFlavors { get; set; }
        public List<SelectListItem> GrainyFlavors { get; set; }
        public List<SelectListItem> GrassyFlavors { get; set; }
        public List<SelectListItem> OffNoteFlavors { get; set; }
        public List<SelectListItem> PeatyFlavors { get; set; }
        public List<SelectListItem> WineyFlavors { get; set; }
        public List<SelectListItem> WoodyFlavors { get; set; }
    }
}
