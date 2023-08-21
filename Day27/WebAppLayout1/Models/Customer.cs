using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppLayout1.Models
    
{
    [Table("Customer")]
    public class Customer
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        public string ODLimit { get; set; }
        [Required]
        public string MembershipSDate { get; set; }

    }
}
