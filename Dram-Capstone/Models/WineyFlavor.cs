using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models
{
    public class WineyFlavor
    {
        [Key]
        public int WineyFlavorId { get; set; }

        public string Name { get; set; }
    }
}
