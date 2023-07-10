using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Depno { get; set; }
        public string? Depname { get; set; }
    }
}
