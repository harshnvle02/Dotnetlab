using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginDemoMvc.Models
{
    [Table("Empdata")]
    public class Emp
    {
        [Key]
        [Column("Id", TypeName = "int")]
        public int Eid { get; set; }
        [Column("Ename", TypeName = "varchar(40)")]
        public string Ename { get; set; }
        [Column("Email", TypeName = "varchar(40)")]
        public string Email { get; set; }
        [Column("Address", TypeName = "varchar(40)")]
        public string Address { get; set; }
    }
}
