using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserData.Models
{
    public class Employee
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int PkEmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Skills { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public string Hobbies { get; set; }
    }
}
