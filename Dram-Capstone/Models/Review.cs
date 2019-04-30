using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dram_Capstone.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Reviewed")]
        public DateTime DateCreated { get; set; }
        
        [Required]
        [Display(Name = "Distillery Name")]
        public string Distillery { get; set; }

        [Required]
        [Display(Name = "Whiskey Review ID")]
        public int WhiskeyReview_Id { get; set; }

        [Required]
        [Display(Name = "User Id")]
        public string User_Id { get; set; }

        public bool Favorite { get; set; }

        [Required]
        [Range(1, 100,
        ErrorMessage = "Your review must be between 1 and 100")]
        [Display(Name = "Review Score")]
        public int ReviewScore { get; set; }

        [Display(Name = "Woody Descriptor")]
        public int WoodyFlavor_Id { get; set; }

        [Display(Name = "Winey Descriptor")]
        public int WineyFlavor_Id { get; set; }

        [Display(Name = "Off Notes Descriptor")]
        public int OffNotesFlavor_Id { get; set; }

        [Display(Name = "Fruity Descriptor")]
        public int FruityFlavor_Id { get; set; }

        [Display(Name = "Fragrant Descriptor")]
        public int FragrantFlavor_Id { get; set; }

        [Display(Name = "Peaty Descriptor")]
        public int PeatyFlavor_Id { get; set; }

        [Display(Name = "Grainy Descriptor")]
        public int GrainyFlavor_Id { get; set; }

        [Display(Name = "Grassy Descriptor")]
        public int GrassyFlavor_Id { get; set; }
    }
}