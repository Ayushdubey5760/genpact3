using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Course
    {
        [Key]
        public int CID { get; set; }
        public string CName { get; set; }
        public string Technology { get; set; }
        public string Status { get; set; }
    }
}
