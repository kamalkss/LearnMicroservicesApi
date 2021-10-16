using System.ComponentModel.DataAnnotations;

namespace LearnMicroservices.Models
{
    public class Platforms
    {
        [Key]
        [Required]
        public Guid PlatformId { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Publisher {  get; set; }
        [Required]
        public string Cost {  get; set;}
    }
}
