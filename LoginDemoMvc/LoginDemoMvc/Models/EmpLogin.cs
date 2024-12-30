using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginDemoMvc.Models
{
    [Table("Emp")]
    public class EmpLogin
    {
        [Key]
        [Column("Id", TypeName = "int")]
        public int EmpID { get; set; }
        [Column("Ename", TypeName = "varchar(40)")]
        public string Ename { get; set; }

        [Column("Password", TypeName = "int")]
        public string Password { get; set; }
        [Column("Role", TypeName = "varchar(40)")]
        public string Role { get; set; }
    }
}
