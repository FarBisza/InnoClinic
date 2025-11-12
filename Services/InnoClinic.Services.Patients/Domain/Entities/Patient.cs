using System.ComponentModel.DataAnnotations;

namespace InnoClinic.Services.Patients.Domain.Entities
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public bool IsLinkedToAccount { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AccountId { get; set; }
    }
}