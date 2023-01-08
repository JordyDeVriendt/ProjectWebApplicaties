using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        public string Afbeelding { get; set; }
        [Required]
        public double Prijs { get; set; }
        [Required]
        public string OperatingSystem { get; set; }
        [Required]
        public string CpuCooler { get; set; }
        [Required]
        public string Behuizing { get; set; }
        [Required]
        public string Opslag { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string Moederbord { get; set; }
        [Required]
        public string Cpu { get; set; }
        [Required]
        public string Gpu { get; set; }
    }
}
