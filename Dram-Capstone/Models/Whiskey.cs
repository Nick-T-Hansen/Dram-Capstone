using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dram_Capstone.Models
{
    public class Whiskey
    {
        [Key]
        public int WhiskeyId { get; set; }

        [Required]
        [Display(Name = "Whiskey Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Distillery Name")]
        public string Distillery { get; set; }

        
        [Display(Name = "Whiskey Review Id")]
        public int? WhiskeyReview_Id { get; set; }

        [Required]
        [Display(Name = "User Id")]
        public string User_Id { get; set; }
       
        public bool Favorite { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}