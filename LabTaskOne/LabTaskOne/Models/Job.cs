using System.ComponentModel.DataAnnotations;

namespace LabTaskOne.Models
{
    public class Job
    {
        [Required]
        [StringLength (70)]
        public string fullName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(50)]
        public string position { get; set; }
        [Required]
        [Range (0, 40)]
        public int experience { get; set; }
        [Required]
        [Range(10000, 50000)]
        public int salaryExpectatioin { get; set; }
    }
}
