using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dram_Capstone.Models
{
    public class Review
    {
        [Key]
        public int Review_Id { get; set; }

        
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Reviewed")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Tasting Notes")]
        public string TastingNotes { get; set; }

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
        public int OffNoteFlavor_Id { get; set; }

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