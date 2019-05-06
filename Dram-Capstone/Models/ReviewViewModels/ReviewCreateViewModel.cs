using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models.ReviewViewModels
{
    public class ReviewCreateViewModel
    {
        public Review Review { get; set; }

        public int whiskeyId { get; set; }

        public List<SelectListItem> FragrantFlavors{ get; set; }
        public List<SelectListItem> FruityFlavors { get; set; }
        public List<SelectListItem> GrainyFlavors { get; set; }
        public List<SelectListItem> GrassyFlavors { get; set; }
        public List<SelectListItem> OffNoteFlavors { get; set; }
        public List<SelectListItem> PeatyFlavors { get; set; }
        public List<SelectListItem> WineyFlavors { get; set; }
        public List<SelectListItem> WoodyFlavors { get; set; }
    }
}
