﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dram_Capstone.Models
{
    public class WoodyFlavor
    {
        [Key]
        public int WoodyFlavor_Id { get; set; }

        public string Name { get; set; }
    }
}
