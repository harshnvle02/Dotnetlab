using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpMVC.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        [Column("Id", TypeName ="int")]
        public int EmpId { get; set; }
        [Column("Ename", TypeName = "varchar(40)")]
        public string Ename { get; set; }
        [Column("Password", TypeName = "varchar(40)")]
        public string Password { get; set; }
    }
}
